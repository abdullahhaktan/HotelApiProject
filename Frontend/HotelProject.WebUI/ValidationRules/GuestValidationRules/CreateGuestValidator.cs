using FluentValidation;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(g => g.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez");
            RuleFor(g => g.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez");
            RuleFor(g => g.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez")
                                .MinimumLength(3).WithMessage("Şehir en az 3 karakter olmalıdır")
                                .MaximumLength(20).WithMessage("Şehir en fazla 20 karakter olmalıdır");


            RuleFor(g => g.Name).MinimumLength(3).WithMessage("İsim en az 3 karakter olmalıdır");
            RuleFor(g=>g.Surname).MinimumLength(2).WithMessage("Soyisim en az 2 karakter olmalıdır");

            RuleFor(g=>g.Name).MaximumLength(20).WithMessage("İsim en fazla 20 karakter olmalıdır");
            RuleFor(g => g.Surname).MaximumLength(30).WithMessage("Soyisim en fazla 20 karakter olmalıdır");
        }
    }
}
