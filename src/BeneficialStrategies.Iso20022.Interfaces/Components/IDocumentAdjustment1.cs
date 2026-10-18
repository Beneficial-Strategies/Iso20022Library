// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the amount and reason of the document adjustment.
/// </summary>
[IsoId("_UP-lctp-Ed-ak6NoX_4Aeg_1188294125")]
public interface IDocumentAdjustment1 : IIsoComponent
{
    /// <summary>
    /// Amount of money of the document adjustment.
    /// </summary>
    [IsoId("_UP-lc9p-Ed-ak6NoX_4Aeg_1531842196")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    ActiveOrHistoricCurrencyAndAmount Amount { get; }

    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_UP-ldNp-Ed-ak6NoX_4Aeg_1554008423")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    CreditDebitCode? CreditDebitIndicator { get; }

    /// <summary>
    /// Specifies the reason for the adjustment.
    /// </summary>
    [IsoId("_UP-lddp-Ed-ak6NoX_4Aeg_1641741581")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    IsoMax4Text? Reason { get; }

    /// <summary>
    /// Provides further details on the document adjustment.
    /// </summary>
    [IsoId("_UP-ldtp-Ed-ak6NoX_4Aeg_1656516606")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    IsoMax140Text? AdditionalInformation { get; }
}
