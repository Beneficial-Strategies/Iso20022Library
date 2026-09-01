// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="StatementGroup1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6QsqlZqlEeGSON8vddiWzQ_1977241265
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>BillingStatement</term><description>Min=1</description></item>
///   <item><term>ReceiverIndividualContact</term><description>Max=2</description></item>
///   <item><term>SenderIndividualContact</term><description>Max=2</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
/// No cross-field constraints found for this component.
/// </remarks>
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public class StatementGroup1Validator : AbstractValidator<StatementGroup1>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="StatementGroup1"/>.
    /// </summary>
    public StatementGroup1Validator()
    {
        // GroupIdentification, Receiver, Sender: required (1..1) scalars, already `required`
        // in the C# model — no rule needed.

        RuleFor(x => x.BillingStatement)
            .NotEmpty()
            .WithMessage("StatementGroup1.BillingStatement must contain at least one element (1..*).");

        RuleFor(x => x.SenderIndividualContact)
            .Must(list => list.Count <= 2)
            .WithMessage("StatementGroup1.SenderIndividualContact must not contain more than 2 element(s) (0..2).");

        RuleFor(x => x.ReceiverIndividualContact)
            .Must(list => list.Count <= 2)
            .WithMessage("StatementGroup1.ReceiverIndividualContact must not contain more than 2 element(s) (0..2).");
    }
}
