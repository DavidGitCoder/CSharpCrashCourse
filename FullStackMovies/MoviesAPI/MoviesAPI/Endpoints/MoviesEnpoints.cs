using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Entities;

namespace MoviesAPI.Endpoints
{
    public static class MoviesEnpoints
    {
        //Extension Method
        public static RouteGroupBuilder MapMoviesEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("movies");

            //GET /movies
            group.MapGet("/", async (MovieContext movieContext) => await movieContext.Movies.Include("Genre").ToListAsync());

            //GET /movies/{id}
            group.MapGet("/{id}", async (MovieContext movieContext, int id) =>
            {
                Movie? movie = await movieContext.Movies.Include("Genre").FirstOrDefaultAsync(x => x.Id == id);

                return movie is null ? Results.NotFound() : Results.Ok(movie);
            });

            //POST /movies
            group.MapPost("/", async (Movie newMovie, MovieContext movieContext) =>
            {
                newMovie.Genre = await movieContext.Genres.FirstOrDefaultAsync(x=> x.Id == newMovie.GenreId);
                movieContext.Movies.Add(newMovie);
                await movieContext.SaveChangesAsync();
                return Results.Created($"/movies{newMovie.Id}", newMovie);

                
            });

            return group;
        }
    }
}
