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
[IsoId("_fY-TsaizEeK6T65WbewxKQ")]
[DisplayName("Remittance Amount")]
public record RemittanceAmount3
{
    /// <summary>
    /// Amount specified is the exact amount due and payable to the creditor.
    /// </summary>
    [IsoId("_fiNvRaizEeK6T65WbewxKQ")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; }

    /// <summary>
    /// Amount of discount to be applied to the amount due and payable to the creditor.
    /// </summary>
    [IsoId("_fiNvSaizEeK6T65WbewxKQ")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public DiscountAmountAndType1? DiscountAppliedAmount { get; init; }

    /// <summary>
    /// Amount of a credit note.
    /// </summary>
    [IsoId("_fiNvTaizEeK6T65WbewxKQ")]
    [DisplayName("Credit Note Amount")]
    [IsoXmlTag("CdtNoteAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; }

    /// <summary>
    /// Amount of the tax.
    /// </summary>
    [IsoId("_fiNvUaizEeK6T65WbewxKQ")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public TaxAmountAndType1? TaxAmount { get; init; }

    /// <summary>
    /// Specifies detailed information on the amount and reason of the adjustment.
    /// </summary>
    [IsoId("_fiNvVaizEeK6T65WbewxKQ")]
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; init; }

    /// <summary>
    /// Amount of money remitted.
    /// </summary>
    [IsoId("_fiNvWaizEeK6T65WbewxKQ")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }
}
