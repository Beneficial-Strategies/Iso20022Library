// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TransactionAllocation2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _eH5OcbpXEfCPZvweyV2nEg
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Set of elements used to identify each underlying allocation.
/// <list type="table">
///   <item><term>Amount</term><description>ActiveOrHistoricCurrencyAndAmount — required (1..1)</description></item>
///   <item><term>CreditDebitIndicator</term><description>CreditDebitCode — required (1..1); closed enum, no rule needed</description></item>
///   <item><term>Account</term><description>CashAccount40 — required (1..1)</description></item>
///   <item><term>Purpose</term><description>Purpose2Choice_ — required (1..1)</description></item>
///   <item><term>Reference</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>RelatedReferences</term><description>References80Choice_ collection — optional (0..&#8734;)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// <c>Amount</c> is an <c>ActiveOrHistoricCurrencyAndAmount</c> (plain record, not an
/// <see cref="IIsoSimpleValue{T}"/> wrapper) — its <c>Currency</c> and <c>Amount</c> fields are
/// validated inline here per the established convention (see <c>PaymentTransaction137Validator</c>
/// and <c>AmountAndDirection5Validator</c>): ISO 4217 three-letter currency pattern, amount
/// greater than zero.
///
/// Dependency injection: <c>Account</c>, <c>Purpose</c>, and <c>RelatedReferences</c> (each item)
/// are each validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded
/// <c>new</c> — see the two constructors below.
/// </remarks>
public class TransactionAllocation2Validator : AbstractValidator<TransactionAllocation2>
{
    private static readonly Regex CurrencyRegex =
        new(@"^[A-Z]{3}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for the required <c>Account</c> and <c>Purpose</c> building blocks, and the optional
    /// <c>RelatedReferences</c> collection's item type — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    public TransactionAllocation2Validator(
        IValidator<CashAccount40> accountValidator,
        IValidator<Purpose2Choice_> purposeValidator,
        IValidator<References80Choice_> relatedReferencesValidator
    )
    {
        // ── Amount (ActiveOrHistoricCurrencyAndAmount, required 1..1) ────────────────
        RuleFor(x => x.Amount.Currency)
            .NotEmpty()
            .Matches(CurrencyRegex)
            .WithMessage(
                "TransactionAllocation2.Amount.Currency must be a valid ISO 4217 three-letter currency code (e.g. EUR, USD)."
            );
        RuleFor(x => x.Amount.Amount)
            .GreaterThan(0)
            .WithMessage("TransactionAllocation2.Amount.Amount must be greater than zero.");

        // CreditDebitIndicator: closed CreditDebitCode enum, required — no rule needed.
        // Reference: Max35Text, required — length enforced by struct constructor, no rule needed.

        RuleFor(x => x.Account).SetValidator(accountValidator!);
        RuleFor(x => x.Purpose).SetValidator(purposeValidator!);

        RuleForEach(x => x.RelatedReferences).SetValidator(relatedReferencesValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TransactionAllocation2Validator()
        : this(new CashAccount40Validator(), new Purpose2Choice_Validator(), new References80Choice_Validator()) { }
}
