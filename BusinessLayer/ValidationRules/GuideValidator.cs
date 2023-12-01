using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator: AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen rehber adını soyadını giriniz..");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz..");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen açıklama bilgisi giriniz...");
            RuleFor(x => x.Description).MaximumLength(30).WithMessage("Lütfen 30 Karekterden kısa açıklama bilgisi giriniz...");
        }
    }
}
