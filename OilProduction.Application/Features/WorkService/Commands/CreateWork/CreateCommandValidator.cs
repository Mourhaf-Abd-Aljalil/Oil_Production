using FluentValidation;

namespace OilProduction.Application.Features.WorkService.Commands.CreateWork
{
    public class CreateCommandValidator : AbstractValidator<CreateWorkCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(w => w.Address)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);

            RuleFor(w => w.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(w => w.PhoneNumber)
                .NotNull()
                .NotEmpty()
                .MaximumLength(20);

        }
    }
}