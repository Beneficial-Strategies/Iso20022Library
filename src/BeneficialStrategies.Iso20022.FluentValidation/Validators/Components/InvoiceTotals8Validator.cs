// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="InvoiceTotals8"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _xQ9M3Uw0EfCpsI1b9uv5FQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>ServiceCategoryTotals</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public class InvoiceTotals8Validator : AbstractValidator<InvoiceTotals8>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="InvoiceTotals8"/>.
    /// </summary>
    public InvoiceTotals8Validator()
    {
        // AccountIdentification (AccountIdentification38Choice_) and InvoiceTotals
        // (InvoiceTotals7): required (1..1) and already `required` C# properties — no rule
        // needed. No validator exists yet for either; nested fields unvalidated.

        // ServiceCategoryTotals: ServiceCategoryTotals7, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.ServiceCategoryTotals)
            .NotEmpty()
            .WithMessage("InvoiceTotals8.ServiceCategoryTotals must contain at least one element (1..∞).");
    }
}
