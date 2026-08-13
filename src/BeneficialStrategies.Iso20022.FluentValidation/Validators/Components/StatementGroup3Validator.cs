// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="StatementGroup3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _BMC6W249EeiU9cctagi5ow
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
public sealed class StatementGroup3Validator : AbstractValidator<StatementGroup3>
{
    public StatementGroup3Validator()
    {
        // GroupIdentification, Receiver, Sender: required (1..1) scalars, already `required`
        // in the C# model — no rule needed.

        RuleFor(x => x.BillingStatement)
            .NotEmpty()
            .WithMessage("StatementGroup3.BillingStatement must contain at least one element (1..*).");

        RuleFor(x => x.SenderIndividualContact)
            .Must(list => list.Count <= 2)
            .WithMessage("StatementGroup3.SenderIndividualContact must not contain more than 2 element(s) (0..2).");

        RuleFor(x => x.ReceiverIndividualContact)
            .Must(list => list.Count <= 2)
            .WithMessage("StatementGroup3.ReceiverIndividualContact must not contain more than 2 element(s) (0..2).");
    }
}
