// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CashSortingCriterion1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Uw6IQtp-Ed-ak6NoX_4Aeg_1294908608
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>ForecastBreakdownDetails</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public class CashSortingCriterion1Validator : AbstractValidator<CashSortingCriterion1>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="CashSortingCriterion1"/>.
    /// </summary>
    public CashSortingCriterion1Validator()
    {
        // SortingCriterionType (SortCriteria1Choice_): required (1..1) and already `required`
        // C# property — no rule needed. No validator exists yet for SortCriteria1Choice_
        // variants; nested fields unvalidated.

        // ForecastBreakdownDetails: ForecastParameter1, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.ForecastBreakdownDetails)
            .NotEmpty()
            .WithMessage(
                "CashSortingCriterion1.ForecastBreakdownDetails must contain at least one element (1..*)."
            );
    }
}
