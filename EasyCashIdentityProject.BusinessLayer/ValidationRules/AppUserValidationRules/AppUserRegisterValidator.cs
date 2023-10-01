using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre onayı boş geçilemez");

            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz");


            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreler uyuşmamaktadır.");

            RuleFor(x => x.Email).NotNull().WithMessage("Lütfen geçerli bir mail adresi giriniz");
        }
    }
}
