// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReferredDocumentAmount1Choice;

/// <summary>
/// Amount specified is the exact amount due and payable to the creditor.
/// </summary>
[IsoId("_QGJCQ9p-Ed-ak6NoX_4Aeg_-888106466")]
public interface IDuePayableAmount : IReferredDocumentAmount1Choice, IIsoChoiceVariant
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
