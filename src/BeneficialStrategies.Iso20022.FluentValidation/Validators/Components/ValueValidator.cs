// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Value"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _SVDJ0dp-Ed-ak6NoX_4Aeg_-76711377
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>AlternateCurrencyItem</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public class ValueValidator : AbstractValidator<Value>
{
    public ValueValidator()
    {
        // BaseCurrencyItem (ActiveOrHistoricCurrencyAndAmount): required (1..1) and already
        // `required` C# property — no rule needed. No validator exists for
        // ActiveOrHistoricCurrencyAndAmount, but Currency and Amount are already `required`.

        // AlternateCurrencyItem: ActiveOrHistoricCurrencyAndAmount, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.AlternateCurrencyItem)
            .NotEmpty()
            .WithMessage("Value.AlternateCurrencyItem must contain at least one element (1..∞).");
    }
}
