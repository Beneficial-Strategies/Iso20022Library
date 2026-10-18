// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceAmount1"/>
[IsoId("_QGJCSNp-Ed-ak6NoX_4Aeg_-903711790")]
[DisplayName("Remittance Amount")]
public partial record RemittanceAmount1
{
    /// <inheritdoc cref="IRemittanceAmount1.DuePayableAmount"/>
    [IsoId("_QGJCSdp-Ed-ak6NoX_4Aeg_-902791779")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount1.DiscountAppliedAmount"/>
    [IsoId("_QGJCStp-Ed-ak6NoX_4Aeg_-902791719")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DiscountAppliedAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount1.CreditNoteAmount"/>
    [IsoId("_QGSzQNp-Ed-ak6NoX_4Aeg_-902791574")]
    [DisplayName("Credit Note Amount")]
    [IsoXmlTag("CdtNoteAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount1.TaxAmount"/>
    [IsoId("_QGSzQdp-Ed-ak6NoX_4Aeg_-902791543")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TaxAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount1.AdjustmentAmountAndReason"/>
    [IsoId("_QGSzQtp-Ed-ak6NoX_4Aeg_1253864295")]
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public ValueList<DocumentAdjustment1> AdjustmentAmountAndReason { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount1.RemittedAmount"/>
    [IsoId("_QGSzQ9p-Ed-ak6NoX_4Aeg_-902791697")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }
}
