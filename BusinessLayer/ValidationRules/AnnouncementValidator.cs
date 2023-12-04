using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Başlık kısmı boş geçemezsiniz..");
            RuleFor(x =>x.Title).NotEmpty().WithMessage("Başlık kısmı boş geçemezsiniz..");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 Karakter veri girişi yapınız...");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 Karakter veri girişi yapınız...");
            
            RuleFor(x => x.Content).NotNull().WithMessage("Lütfen açıklama kısmını boş geçmeyeniz..");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen en az 20 Karakter veri girişi yapınız..."); 
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 Karakter veri girişi yapınız...");
        }
    }
}
