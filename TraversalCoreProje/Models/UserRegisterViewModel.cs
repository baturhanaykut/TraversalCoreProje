using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi adresinizi giriniz")]
        public string Password { get; set; }  
        
        [Required(ErrorMessage = "Lütfen şifrenizi tekrar adresinizi giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ComfirmPassword { get; set; }
        

    }
}
