// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="BillingMethod4"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6QGNo5qlEeGSON8vddiWzQ_288570123
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>ServiceDetail</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public sealed class BillingMethod4Validator : AbstractValidator<BillingMethod4>
{
    public BillingMethod4Validator()
    {
        // TaxCalculation (TaxCalculation1): required (1..1) and already `required` C# property —
        // no rule needed. No validator exists yet for TaxCalculation1; nested fields unvalidated.

        // ServiceDetail: BillingServiceParameters2, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.ServiceDetail)
            .NotEmpty()
            .WithMessage("BillingMethod4.ServiceDetail must contain at least one element (1..*).");
    }
}
