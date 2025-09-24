using MoviesBlazor.Models;
using System;
using static System.Net.WebRequestMethods;

namespace MoviesBlazor.Clients
{
    public class MoviesClient(HttpClient httpClient)
    {

        public async Task<Movie[]> GetMoviesAsync() => await httpClient.GetFromJsonAsync<Movie[]>("movies") ?? []; //if is null return empty Array
        //Task<Movie[]> → the method returns a “promise” of an array of movies in the future.
        //Think of Task<Movie[]> as a “movie container that will arrive later.”
        //        httpClient → the HttpClient injected via DI.

        //GetFromJsonAsync<T>(url) → a helper method that:
        //Makes an HTTP GET request to BaseAddress + url.

        //In your case: https://localhost:7152/movies
        //Movie[] tells the method: “expect an array of Movie objects.”
    }
}
