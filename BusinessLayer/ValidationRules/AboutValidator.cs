using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz..");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen görsel seçiniz..");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen en az 50 karakterlik açıklama bilgisi giriniz...");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Lütfen açıklmayı kısaltın...");
        }
    }
}
