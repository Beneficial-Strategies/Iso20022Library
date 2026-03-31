// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Contract4.
/// </summary>
[IsoId("_2X0v3TEyEe6g-ffJsqGiSA")]
[DisplayName("Trade Contract4")]
public record TradeContract4
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Attachment.
    /// </summary>
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public ValueList<DocumentGeneralInformation5> Attachment { get; init; } = [];

    /// <summary>
    /// Buyer.
    /// </summary>
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty6> Buyer { get; init; } = [];

    /// <summary>
    /// Contract Document Identification.
    /// </summary>
    [DisplayName("Contract Document Identification")]
    [IsoXmlTag("CtrctDocId")]
    public DocumentIdentification22? ContractDocumentIdentification { get; init; }

    /// <summary>
    /// Exchange Rate Information.
    /// </summary>
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Maturity Date.
    /// </summary>
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Payment Schedule.
    /// </summary>
    [DisplayName("Payment Schedule")]
    [IsoXmlTag("PmtSchdl")]
    public InterestPaymentDateRange1? PaymentSchedule { get; init; }

    /// <summary>
    /// Prolongation Flag.
    /// </summary>
    [DisplayName("Prolongation Flag")]
    [IsoXmlTag("PrlngtnFlg")]
    public IsoTrueFalseIndicator? ProlongationFlag { get; init; }

    /// <summary>
    /// Seller.
    /// </summary>
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty6> Seller { get; init; } = [];

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Shipment Schedule.
    /// </summary>
    [DisplayName("Shipment Schedule")]
    [IsoXmlTag("ShipmntSchdl")]
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; }

    /// <summary>
    /// Start Date.
    /// </summary>
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Trade Type Identification.
    /// </summary>
    [DisplayName("Trade Type Identification")]
    [IsoXmlTag("TradTpId")]
    public IsoMax35Text? TradeTypeIdentification { get; init; }
}
