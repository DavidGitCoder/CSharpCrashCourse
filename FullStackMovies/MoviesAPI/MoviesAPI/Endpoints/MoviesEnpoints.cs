using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Entities;

namespace MoviesAPI.Endpoints
{
    public static class MoviesEnpoints
    {
        //Extension Method
        public static RouteGroupBuilder MapMoviesEndpoints(this WebApplication app) //this: signifies an extension method to WebApplication assigned to "app" here
        {
            var group = app.MapGroup("movies").WithParameterValidation(); 
            //WithParameterValidation() (from a NuGet Package called "MinimalApis.Extension":
            //helps validates the parameters passed to movies in POST method

            // ENDPOINTS
            //GET /movies
            group.MapGet("/", GetAllMovies); //replaced Lambas with functions for clarity (otherwise async (MovieContext movieContext) => {code logic}
            
            //GET /movies/{id}
            group.MapGet("/{id}", GetMovieById);
            
            //POST /movies
            group.MapPost("/", AddMovie);
            
            //UPDATE /movies/1
            group.MapPut("/{id}", UpdateMovie);
           
            //DELETE /movies/1
            group.MapDelete("/{id}", DeleteMovie);
            return group;

            // Handlers Delegates
            static async Task<IResult> GetAllMovies(MovieContext movieContext)
            {
                List<Movie> movies = await movieContext.Movies.Include("Genre").ToListAsync();
                return TypedResults.Ok(movies);
            }

            static async Task<IResult> GetMovieById(MovieContext movieContext, int id)
            {

                Movie? movie = await movieContext.Movies.Include("Genre").FirstOrDefaultAsync(x => x.Id == id);

                return movie is null ? TypedResults.NotFound() : TypedResults.Ok(movie);
            }

            static async Task<IResult> AddMovie(Movie newMovie, MovieContext movieContext)
            {
                newMovie.Genre = await movieContext.Genres.FirstOrDefaultAsync(x => x.Id == newMovie.GenreId);
                movieContext.Movies.Add(newMovie);
                await movieContext.SaveChangesAsync();
                return TypedResults.Created($"/movies{newMovie.Id}", newMovie);
            }

            static async Task<IResult> UpdateMovie(int id, Movie movie, MovieContext movieContext)
            {
                Movie? existingMovie = await movieContext.Movies.FindAsync(id);
                if (existingMovie is null) return Results.NotFound();

                var genre = await movieContext.Genres.FindAsync(movie.GenreId);
                //if (genre is null) return Results.BadRequest("Invalid GenreId");

                if (movie.Name is not null) existingMovie.Name = movie.Name;
                if (movie.Price != 0) existingMovie.Price = movie.Price;
                if (movie.GenreId != 0)
                {
                    existingMovie.GenreId = movie.GenreId;
                    existingMovie.Genre = genre; //seems like EF automatically assigns the fetched genre 
                }
                if (movie.ReleaseDate != default) existingMovie.ReleaseDate = movie.ReleaseDate;

                movieContext.Movies.Update(existingMovie);
                int affectedRows = await movieContext.SaveChangesAsync();

                //return (affectedRows > 0)
                //? Results.Accepted($"/movies{existingMovie.Id}", existingMovie)
                //: Results.BadRequest($"Update failed for movie {movie.Name}");
                return TypedResults.NoContent();
            }

            static async Task<IResult> DeleteMovie(int id, MovieContext movieContext)
            {
                Movie? existingMovie = await movieContext.Movies.FindAsync(id);
                if (existingMovie is null) return Results.NotFound($"Movie with id: {id} doesn't exist");

                movieContext.Movies.Remove(existingMovie);
                await movieContext.SaveChangesAsync();

                return TypedResults.NoContent();

            }
        }


    }
}
