using DotNetCore.Validation;
using DotNetCoreArchitecture.CrossCutting.Resources;
using DotNetCoreArchitecture.Model.Models;
using FluentValidation;

namespace DotNetCoreArchitecture.Model.Validators
{
    public sealed class SignedInValidator : Validator<SignedInModel>
    {
        public SignedInValidator() : base(Texts.LoginPasswordInvalid)
        {
            RuleFor(x => x).NotNull();
            RuleFor(x => x.UserId).GreaterThan(0);
        }
    }
}
