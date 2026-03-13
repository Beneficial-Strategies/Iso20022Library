// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CaseAssignment5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _BzPdIW49EeiU9cctagi5ow
/// Spec source: CaseAssignment5 message component.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1), MinLength=1, MaxLength=35</description></item>
///   <item><term>Assigner</term><description>Party40Choice — required (1..1)</description></item>
///   <item><term>Assignee</term><description>Party40Choice — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1)</description></item>
/// </list>
/// </remarks>
public sealed class CaseAssignment5Validator : AbstractValidator<CaseAssignment5>
{
    public CaseAssignment5Validator()
    {
        RuleFor(x => x.Identification)
            .NotEmpty()
                .WithMessage("CaseAssignment5.Identification is required (Max35Text, 1..1).")
            .MinimumLength(1)
            .MaximumLength(35)
                .WithMessage("CaseAssignment5.Identification must not exceed 35 characters (Max35Text).");

        RuleFor(x => x.Assigner)
            .NotNull()
                .WithMessage("CaseAssignment5.Assigner is required (Party40Choice, 1..1).");

        RuleFor(x => x.Assignee)
            .NotNull()
                .WithMessage("CaseAssignment5.Assignee is required (Party40Choice, 1..1).");

        RuleFor(x => x.CreationDateTime)
            .NotEqual(default(DateTime))
                .WithMessage("CaseAssignment5.CreationDateTime is required (ISODateTime, 1..1).");
    }
}
