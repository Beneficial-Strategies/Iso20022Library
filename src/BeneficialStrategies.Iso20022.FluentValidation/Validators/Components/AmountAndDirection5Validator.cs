// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AmountAndDirection5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _T2Wkhdp-Ed-ak6NoX_4Aeg_-2124038249
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Amount of money debited or credited on the books of an account servicer.
/// <list type="table">
///   <item><term>Amount</term><description>ActiveCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>CreditDebit</term><description>CreditDebitCode — optional (0..1); closed enum, no rule needed</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// <c>Amount</c> is an <c>ActiveCurrencyAndAmount</c> (plain <c>Currency</c>/<c>Amount</c> record
/// in the <c>Amounts</c> namespace, not an <see cref="IIsoSimpleValue{T}"/> wrapper) — its
/// <c>Currency</c> and <c>Amount</c> fields are validated inline here per the established
/// convention (see <c>PaymentTransaction137Validator</c>): ISO 4217 three-letter currency pattern,
/// amount greater than zero.
/// </remarks>
public class AmountAndDirection5Validator : AbstractValidator<AmountAndDirection5>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    public AmountAndDirection5Validator()
    {
        // ── Amount (ActiveCurrencyAndAmount, required 1..1) ──────────────────────────
        RuleFor(x => x.Amount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage("AmountAndDirection5.Amount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD).");

        RuleFor(x => x.Amount.Amount)
            .GreaterThan(0)
            .WithMessage("AmountAndDirection5.Amount.Amount must be greater than zero.");

        // CreditDebit: closed CreditDebitCode enum, optional — no rule needed.
    }
}
