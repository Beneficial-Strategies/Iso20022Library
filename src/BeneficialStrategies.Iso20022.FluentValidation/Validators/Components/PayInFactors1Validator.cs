// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="PayInFactors1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _S3PXsAEcEeCQm6a_G2yO_w_-1038379529
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>CurrencyFactors</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public sealed class PayInFactors1Validator : AbstractValidator<PayInFactors1>
{
    public PayInFactors1Validator()
    {
        // AggregateShortPositionLimit (ActiveCurrencyAndAmount): required (1..1) and already
        // `required` C# property — no rule needed. No validator exists yet for it; nested
        // fields unvalidated.

        // CurrencyFactors: CurrencyFactors1, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.CurrencyFactors)
            .NotEmpty()
            .WithMessage("PayInFactors1.CurrencyFactors must contain at least one element (1..∞).");
    }
}
