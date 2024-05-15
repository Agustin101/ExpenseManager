using FluentValidation;

namespace Application.UseCases.MoneyMovementFeatures.CreateMoneyMovement;

public sealed class CreateMoneyMovementValidator : AbstractValidator<CreateMoneyMovementRequest>
{
    public CreateMoneyMovementValidator()
    {
        RuleFor(mm => mm.CategoryId).NotNull();
        RuleFor(mm => mm.MoneyAmount).NotNull();
        RuleFor(mm => mm.MovementType).NotNull().IsInEnum();
        RuleFor(mm => mm.Description).MaximumLength(100).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
    }
}
