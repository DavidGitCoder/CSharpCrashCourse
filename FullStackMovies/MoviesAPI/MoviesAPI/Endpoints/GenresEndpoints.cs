using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;
using MoviesAPI.Entities;

namespace MoviesAPI.Endpoints
{
    public static class GenresEndpoints
    {
        public static RouteGroupBuilder MapGenresEndpoints(this WebApplication app)
        {

            var genre = app.MapGroup("genres").WithParameterValidation();

            // *** ENDPOINTS ***

            genre.MapGet("/", GetAllGenres);
            genre.MapGet("/{id}", GetGenreById);
            genre.MapPost("/", AddGenre);
            //genre.MapPost("/{id}", AddGenre);

            // *****************

            return genre;
        }

        private static async Task<IResult> GetAllGenres(MovieContext movieContext)
        {
            List<Genre> genres = await movieContext.Genres.ToListAsync();
            return genres is null
                ? TypedResults.NotFound("No genres were found")  
                :TypedResults.Ok(genres);
        }

        private static async Task<Results<Ok<Genre>, NotFound<string>>> GetGenreById(int id, MovieContext movieContext)
        {
            Genre? genre = await movieContext.Genres.FindAsync(id);
            return genre is null
                ? TypedResults.NotFound($"Couldn't find genre with Id: {id}")
                : TypedResults.Ok(genre);
        }
        private static async Task<Created<Genre>> AddGenre(Genre newGenre, MovieContext movieContext)
        {
            movieContext.Genres.Add(newGenre);
            await movieContext.SaveChangesAsync();
            return TypedResults.Created($"/genres/{newGenre.Id}", newGenre);
        }
    }
}
