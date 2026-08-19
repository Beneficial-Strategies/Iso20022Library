// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TaxCalculation1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6R49apqlEeGSON8vddiWzQ_163014572
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>TaxIdentification</term><description>Min=1, Max=3</description></item>
///   <item><term>TaxableServiceChargeConversion</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public class TaxCalculation1Validator : AbstractValidator<TaxCalculation1>
{
    public TaxCalculation1Validator()
    {
        // HostCurrency (ActiveOrHistoricCurrencyCode), TotalTaxableServiceChargeHostAmount,
        // TotalTax (AmountAndDirection34): required (1..1) and already `required` C#
        // properties — no rule needed. No validator exists yet for AmountAndDirection34;
        // nested fields unvalidated.

        // TaxableServiceChargeConversion: BillingServicesAmount3, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.TaxableServiceChargeConversion)
            .NotEmpty()
            .WithMessage(
                "TaxCalculation1.TaxableServiceChargeConversion must contain at least one element (1..∞)."
            );

        // TaxIdentification: BillingServicesTax3, 1..3 — NEEDS NotEmpty AND Max=3 RULE.
        RuleFor(x => x.TaxIdentification)
            .NotEmpty()
            .WithMessage("TaxCalculation1.TaxIdentification must contain at least one element (1..3).");

        RuleFor(x => x.TaxIdentification)
            .Must(list => list.Count <= 3)
            .WithMessage("TaxCalculation1.TaxIdentification must not contain more than 3 element(s) (1..3).");
    }
}
