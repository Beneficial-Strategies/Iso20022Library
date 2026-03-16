// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Nature of the amount and currency on a document referred to in the remittance section, typically either the original amount due/payable or the amount actually remitted for the referenced document.
/// </summary>
[IsoId("_QGJCSNp-Ed-ak6NoX_4Aeg_-903711790")]
[DisplayName("Remittance Amount")]
public record RemittanceAmount1
{
    /// <summary>
    /// Amount specified is the exact amount due and payable to the creditor.
    /// </summary>
    [IsoId("_QGJCSdp-Ed-ak6NoX_4Aeg_-902791779")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; }

    /// <summary>
    /// Amount of money that results from the application of an agreed discount to the amount due and payable to the creditor.
    /// </summary>
    [IsoId("_QGJCStp-Ed-ak6NoX_4Aeg_-902791719")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DiscountAppliedAmount { get; init; }

    /// <summary>
    /// Amount specified for the referred document is the amount of a credit note.
    /// </summary>
    [IsoId("_QGSzQNp-Ed-ak6NoX_4Aeg_-902791574")]
    [DisplayName("Credit Note Amount")]
    [IsoXmlTag("CdtNoteAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; }

    /// <summary>
    /// Quantity of cash resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_QGSzQdp-Ed-ak6NoX_4Aeg_-902791543")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TaxAmount { get; init; }

    /// <summary>
    /// Set of elements used to provide information on the amount and reason of the document adjustment.
    /// </summary>
    [IsoId("_QGSzQtp-Ed-ak6NoX_4Aeg_1253864295")]
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; init; }

    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("_QGSzQ9p-Ed-ak6NoX_4Aeg_-902791697")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }
}
