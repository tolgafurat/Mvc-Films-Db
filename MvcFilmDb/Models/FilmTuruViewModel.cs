using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcFilmDb.Models
{
    public class FilmTuruViewModel
    {
        public List<Film>? filmler { get; set; }
        public SelectList? turler { get; set; }
        public string? filmTuru { get; set; }
        public string? arama { get; set; }
    }
}
