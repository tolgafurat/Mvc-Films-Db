using System.ComponentModel.DataAnnotations;

namespace MvcFilmDb.Models
{
    public class Film
    {
        public int id { get; set; }
        [Display(Name = "Başlık")]
        public string? baslik { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Çıkış Tarihi")]
        public DateTime cikisTarihi { get; set; }
        [Display(Name = "Tür")]
        public string? tur { get; set; }
        [Display(Name = "Yönetmen")]
        public string yonetmen { get; set; }  
    }
}
