using System.ComponentModel.DataAnnotations;

namespace meetingday.Models
{
    public class Userinfo
    {

        public int Id { get; set; } //user id tutucu

        [Required(ErrorMessage = "Lütfen ismini doldur ")]
        public string? Name { get; set; } 

        [Required(ErrorMessage = "Lütfen numaranı gir")]
        public string? Telnumber { get; set; }

        [Required(ErrorMessage = "Lütfen Emailini gir")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Lütfen seçimini yap")]
        public bool? WillAttend { get; set; } 
    }
}
