// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceAmount3"/>
[IsoId("_fY-TsaizEeK6T65WbewxKQ")]
[DisplayName("Remittance Amount")]
public partial record RemittanceAmount3
{
    /// <inheritdoc cref="IRemittanceAmount3.DuePayableAmount"/>
    [IsoId("_fiNvRaizEeK6T65WbewxKQ")]
    [DisplayName("Due Payable Amount")]
    [IsoXmlTag("DuePyblAmt")]
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount3.DiscountAppliedAmount"/>
    [IsoId("_fiNvSaizEeK6T65WbewxKQ")]
    [DisplayName("Discount Applied Amount")]
    [IsoXmlTag("DscntApldAmt")]
    public ValueList<DiscountAmountAndType1> DiscountAppliedAmount { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount3.CreditNoteAmount"/>
    [IsoId("_fiNvTaizEeK6T65WbewxKQ")]
    [DisplayName("Credit Note Amount")]
    [IsoXmlTag("CdtNoteAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; }

    /// <inheritdoc cref="IRemittanceAmount3.TaxAmount"/>
    [IsoId("_fiNvUaizEeK6T65WbewxKQ")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public ValueList<TaxAmountAndType1> TaxAmount { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount3.AdjustmentAmountAndReason"/>
    [IsoId("_fiNvVaizEeK6T65WbewxKQ")]
    [DisplayName("Adjustment Amount And Reason")]
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    public ValueList<DocumentAdjustment1> AdjustmentAmountAndReason { get; init; } = [];

    /// <inheritdoc cref="IRemittanceAmount3.RemittedAmount"/>
    [IsoId("_fiNvWaizEeK6T65WbewxKQ")]
    [DisplayName("Remitted Amount")]
    [IsoXmlTag("RmtdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; }
}
