// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AmountType3Choice;

/// <summary>
/// Amount of money to be moved between the debtor and creditor, expressed in the currency of the debtor&apos;s account, and the currency in which the amount is to be moved.
/// </summary>
[IsoId("_P57LMtp-Ed-ak6NoX_4Aeg_326235198")]
public interface IEquivalentAmount : IAmountType3Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Amount of money to be moved between debtor and creditor, before deduction of charges, expressed in the currency of the debtor&apos;s account, and to be moved in a different currency.|Usage: The first agent will convert the equivalent amount into the amount to be moved.
    /// </summary>
    [IsoId("_P57LNNp-Ed-ak6NoX_4Aeg_853564730")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }

    /// <summary>
    /// Specifies the currency of the to be transferred amount, which is different from the currency of the debtor&apos;s account.
    /// </summary>
    [IsoId("_P57LNdp-Ed-ak6NoX_4Aeg_853564760")]
    [DisplayName("Currency Of Transfer")]
    [IsoXmlTag("CcyOfTrf")]
    ActiveOrHistoricCurrencyCode CurrencyOfTransfer { get; }
}
