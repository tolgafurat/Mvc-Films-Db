using Microsoft.EntityFrameworkCore;
using MvcFilmDb.Data;

namespace MvcFilmDb.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider servisSaglayici)
        {
            using (var context = new MvcFilmDbContext(
                servisSaglayici.GetRequiredService<DbContextOptions<MvcFilmDbContext>>()))
            {
                if (context.Film.Any())
                {
                    return; //database'de film varsa seed'lenmez
                }

                context.Film.AddRange(
                    new Film
                    {
                        baslik = "Dune",
                        cikisTarihi = DateTime.Parse("2021-10-22"),
                        tur = "Bilim Kurgu",
                        yonetmen = "Denis Villeneuve",
                        puan = 8.0
                    },

                    new Film
                    {
                        baslik = "Guillermo del Toro's Pinocchio",
                        cikisTarihi = DateTime.Parse("2022-10-15"),
                        tur = "Animasyon",
                        yonetmen = "Guillermo del Toro",
                        puan = 7.6
                    },

                    new Film
                    {
                        baslik = "Oppenheimer",
                        cikisTarihi = DateTime.Parse("2023-07-21"),
                        tur = "Bilim Kurgu",
                        yonetmen = "Christopher Nolan",
                        puan = 8.8
                    },

                    new Film
                    {
                        baslik = "Face/Off",
                        cikisTarihi = DateTime.Parse("1997-11-27"),
                        tur = "Aksiyon",
                        yonetmen = "John Woo",
                        puan = 7.3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
