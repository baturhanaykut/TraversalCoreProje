﻿using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş geçilemez.");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj alanı boş geçilemez.");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanına en az 5 karakter veri girişi yapmanız gerekli");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Konu alanına en fazla 100 karakter veri girişi yapmanız gerekli");
        }
    }
}
