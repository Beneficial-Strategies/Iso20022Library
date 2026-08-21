// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

/// <summary>
/// Validates <see cref="AmountType4Choice_"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: __S0AAVkJEeSeLKjZh_lWZw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the amount of money to be moved between the debtor and creditor, before deduction of
/// charges, expressed in the currency as ordered by the initiating party.
/// <list type="table">
///   <item><term><see cref="AmountType4Choice.InstructedAmount"/></term><description>Currency/Amount: raw <c>string</c>/<c>decimal</c> (ActiveOrHistoricCurrencyAndAmount-shaped for the XML Ccy-attribute pattern — outside the <c>IIsoSimpleValue&lt;T&gt;</c>/Amounts-namespace coverage tracked by this project)</description></item>
///   <item><term><see cref="AmountType4Choice.EquivalentAmount"/></term><description>Amount: ActiveOrHistoricCurrencyAndAmount (same Amounts-namespace exemption, required 1..1); CurrencyOfTransfer: ActiveOrHistoricCurrencyCode (required 1..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="ActiveOrHistoricCurrencyCodeValidator"/>)</description></item>
/// </list>
///
/// Dispatch: <see cref="FluentValidation.DefaultValidatorExtensions.SetInheritanceValidator{T,TProperty}"/>
/// runtime-type-matches the instance to the correct variant validator below.
///
/// Dependency injection: the <c>EquivalentAmount</c> variant's <c>CurrencyOfTransfer</c> is
/// validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see
/// the two constructors below.
/// </remarks>
public class AmountType4Choice_Validator : AbstractValidator<AmountType4Choice_>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>EquivalentAmount</c> variant's <c>CurrencyOfTransfer</c> — e.g. resolved from a
    /// DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="equivalentAmountCurrencyOfTransferValidator">
    /// Validator for <see cref="AmountType4Choice.EquivalentAmount"/>'s required
    /// <c>CurrencyOfTransfer</c> (ActiveOrHistoricCurrencyCode, 1..1).
    /// </param>
    public AmountType4Choice_Validator(
        IValidator<ActiveOrHistoricCurrencyCode> equivalentAmountCurrencyOfTransferValidator
    )
    {
        // InstructedAmount variant: Currency/Amount are raw string/decimal — Amounts-namespace
        // exemption, no rule needed, so no InlineValidator is registered for it;
        // SetInheritanceValidator leaves an unregistered variant type as always-valid by design
        // (see Party50Choice_Validator's own remarks for the general pattern).

        var equivalentAmountVariantValidator = new InlineValidator<Choices.AmountType4Choice.EquivalentAmount>();
        // Amount: Amounts-namespace exemption, no rule needed.
        equivalentAmountVariantValidator
            .RuleFor(x => x.CurrencyOfTransfer)
            .SetValidator(equivalentAmountCurrencyOfTransferValidator!);

        RuleFor(x => x)
            .SetInheritanceValidator(v =>
            {
                v.Add(equivalentAmountVariantValidator);
            });
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>EquivalentAmount</c>
    /// variant's <c>CurrencyOfTransfer</c> is validated by its own default validator
    /// (<see cref="ActiveOrHistoricCurrencyCodeValidator"/>). Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public AmountType4Choice_Validator()
        : this(new ActiveOrHistoricCurrencyCodeValidator()) { }
}
