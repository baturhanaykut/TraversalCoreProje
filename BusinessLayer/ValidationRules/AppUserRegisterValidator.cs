using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı alanı boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x => x.ComfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");


            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız.");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Lütfen en az 5 karakter veri girişi yapınız.");

            RuleFor(x => x.Password).Equal(y => y.ComfirmPassword).WithMessage("Şifreler birbiri ile uyuşmuyor");            
        }
    }
}
