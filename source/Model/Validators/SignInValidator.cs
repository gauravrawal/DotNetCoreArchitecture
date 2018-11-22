using DotNetCore.Validation;
using DotNetCoreArchitecture.CrossCutting.Resources;
using DotNetCoreArchitecture.Model.Models;
using FluentValidation;

namespace DotNetCoreArchitecture.Model.Validators
{
    public sealed class SignInValidator : Validator<SignInModel>
    {
        public SignInValidator() : base(Texts.LoginPasswordInvalid)
        {
            RuleFor(x => x).NotNull();
            RuleFor(x => x.Login).NotNull().NotEmpty();
            RuleFor(x => x.Password).NotNull().NotEmpty();
        }
    }
}
