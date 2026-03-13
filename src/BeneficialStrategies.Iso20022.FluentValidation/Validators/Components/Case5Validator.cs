// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Case5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _8BF4W248EeiU9cctagi5ow
/// Spec source: Case5 message component.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1), MinLength=1, MaxLength=35</description></item>
///   <item><term>Creator</term><description>Party40Choice — required (1..1)</description></item>
///   <item><term>ReopenCaseIndication</term><description>YesNoIndicator — optional (0..1)</description></item>
/// </list>
/// </remarks>
public sealed class Case5Validator : AbstractValidator<Case5>
{
    public Case5Validator()
    {
        RuleFor(x => x.Identification)
            .NotEmpty()
                .WithMessage("Case5.Identification is required (Max35Text, 1..1).")
            .MinimumLength(1)
            .MaximumLength(35)
                .WithMessage("Case5.Identification must not exceed 35 characters (Max35Text).");

        RuleFor(x => x.Creator)
            .NotNull()
                .WithMessage("Case5.Creator is required (Party40Choice, 1..1).");
    }
}
