// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceAmount2"/>
[IsoId("_tcu6UlkyEeGeoaLUQk__nA_1720061544")]
[DisplayName("Remittance Amount")]
public partial record RemittanceAmount2
{
    /// <inheritdoc cref="IRemittanceAmount2.DuePayableAmount"/>
    [IsoId("_tcu6U1kyEeGeoaLUQk__nA_410413505")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount2.DiscountAppliedAmount"/>
    [IsoId("_tc4rUFkyEeGeoaLUQk__nA_1468630199")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public ValueList<DiscountAmountAndType1> DiscountAppliedAmount { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount2.CreditNoteAmount"/>
    [IsoId("_tc4rUVkyEeGeoaLUQk__nA_-1624173271")]
    [DisplayName("Credit Note Amount")]
    [IsoXmlTag("CdtNoteAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount2.TaxAmount"/>
    [IsoId("_tc4rUlkyEeGeoaLUQk__nA_-1935934653")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public ValueList<TaxAmountAndType1> TaxAmount { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount2.AdjustmentAmountAndReason"/>
    [IsoId("_tc4rU1kyEeGeoaLUQk__nA_41136424")]
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public ValueList<DocumentAdjustment1> AdjustmentAmountAndReason { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount2.RemittedAmount"/>
    [IsoId("_tc4rVFkyEeGeoaLUQk__nA_802163856")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }
}
