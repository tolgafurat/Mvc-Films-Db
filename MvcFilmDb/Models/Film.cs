using System.ComponentModel.DataAnnotations;

namespace MvcFilmDb.Models
{
    public class Film
    {
        public int id { get; set; }
        
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Gerekli alan.")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Lütfen 2-60 karakter arasında giriş yapın.")]
        public string? baslik { get; set; }

        
        [Display(Name = "Çıkış Tarihi")]
        [DataType(DataType.Date)]
        public DateTime cikisTarihi { get; set; }

        [Display(Name = "Tür")]
        [StringLength(15, ErrorMessage = "Lütfen en fazla 15 karakter girin.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Lütfen sadece harf kullanın.")]
        public string? tur { get; set; }

        [Display(Name = "Yönetmen")]
        [Required(ErrorMessage = "Gerekli alan.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Lütfen sadece harf kullanın.")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karakter girin.")]
        public string yonetmen { get; set; }

        [Display(Name = "Puan")]
        [Required(ErrorMessage = "Gerekli alan.")]
        [Range(0, 10, ErrorMessage = "Puan 0 ile 10 arasında olabilir.")]
        public double? puan { get; set; }
    }
}
