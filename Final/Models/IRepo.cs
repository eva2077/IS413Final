﻿using System;
namespace Final.Models
{
    public interface IRepo
    {

        IQueryable<Movie> Movies { get; set; }

        void AddMovie(Movie response);
    }

}

