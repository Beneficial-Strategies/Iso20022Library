// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AmountType2Choice;

/// <summary>
/// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
/// </summary>
[IsoId("_Pxu4jdp-Ed-ak6NoX_4Aeg_-1148058982")]
public interface IInstructedAmount : IAmountType2Choice, IIsoChoiceVariant
{
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Currency")]
    [DisplayName("Currency And Amount _ Currency")]
    [IsoXmlTag("Currency")]
    CurrencyCode Currency { get; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_YXSZF9p-Ed-ak6NoX_4Aeg_-1352517078_Amount")]
    [DisplayName("Currency And Amount _ Amount")]
    [IsoXmlTag("Amount")]
    decimal Amount { get; }
}
