﻿namespace MVCMovies.Models
{
    public class RateMovieRequest
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public string? Comment { get; set; }
    }
}
