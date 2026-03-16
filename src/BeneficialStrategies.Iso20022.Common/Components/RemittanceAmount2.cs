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
[IsoId("_tcu6UlkyEeGeoaLUQk__nA_1720061544")]
[DisplayName("Remittance Amount")]
public record RemittanceAmount2
{
    /// <summary>
    /// Amount specified is the exact amount due and payable to the creditor.
    /// </summary>
    [IsoId("_tcu6U1kyEeGeoaLUQk__nA_410413505")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; }

    /// <summary>
    /// Amount specified for the referred document is the amount of discount to be applied to the amount due and payable to the creditor.
    /// </summary>
    [IsoId("_tc4rUFkyEeGeoaLUQk__nA_1468630199")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public DiscountAmountAndType1? DiscountAppliedAmount { get; init; }

    /// <summary>
    /// Amount specified for the referred document is the amount of a credit note.
    /// </summary>
    [IsoId("_tc4rUVkyEeGeoaLUQk__nA_-1624173271")]
    [DisplayName("Credit Note Amount")]
    [IsoXmlTag("CdtNoteAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; }

    /// <summary>
    /// Quantity of cash resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_tc4rUlkyEeGeoaLUQk__nA_-1935934653")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public TaxAmountAndType1? TaxAmount { get; init; }

    /// <summary>
    /// Specifies detailed information on the amount and reason of the document adjustment.
    /// </summary>
    [IsoId("_tc4rU1kyEeGeoaLUQk__nA_41136424")]
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; init; }

    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("_tc4rVFkyEeGeoaLUQk__nA_802163856")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }
}
