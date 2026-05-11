using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieYearViewModel
{
    public List<Movie>? Movies { get; set;}
    public SelectList? Years {get; set;}
    public string? MovieYear {get; set;}
    public string? SearchString{get; set;}
}