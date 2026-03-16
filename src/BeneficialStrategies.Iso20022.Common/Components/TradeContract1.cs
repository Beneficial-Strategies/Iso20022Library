// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement between the parties, stipulating the terms and conditions of the delivery of goods or services.
/// </summary>
[IsoId("_1lQO0NLJEeSdq5yU2aaSNw")]
[DisplayName("Trade Contract")]
public record TradeContract1
{
    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    [IsoId("_RZltddNDEeSDLevdaFPXHw")]
    [DisplayName("Contract Document Identification")]
    [IsoXmlTag("CtrctDocId")]
    public DocumentIdentification22? ContractDocumentIdentification { get; init; }

    /// <summary>
    /// Amount of the trade contract.
    /// </summary>
    [IsoId("_oHnIENNEEeSDLevdaFPXHw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    [IsoId("_RZltc9NDEeSDLevdaFPXHw")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty2> Buyer { get; init; } = [];

    // ID for the above is _RZltc9NDEeSDLevdaFPXHw

    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    [IsoId("_RZltdNNDEeSDLevdaFPXHw")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty2> Seller { get; init; } = [];

    // ID for the above is _RZltdNNDEeSDLevdaFPXHw

    /// <summary>
    /// Planned final payment date at the time of issuance.
    /// </summary>
    [IsoId("_r21y4NNEEeSDLevdaFPXHw")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate MaturityDate { get; init; }

    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// </summary>
    [IsoId("_wrZHANNEEeSDLevdaFPXHw")]
    [DisplayName("Prolongation Flag")]
    [IsoXmlTag("PrlngtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator ProlongationFlag { get; init; }

    /// <summary>
    /// Start date of the trade contract.
    /// </summary>
    [IsoId("_y6NvANNEEeSDLevdaFPXHw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate StartDate { get; init; }

    /// <summary>
    /// Currency in which the trade is being settled.
    /// </summary>
    [IsoId("_2jC24NNEEeSDLevdaFPXHw")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; }

    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_wb2E8dONEeSQ_-lmj1tzfw")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Schedule of the payments defined for the trade contract.
    /// </summary>
    [IsoId("_5ukXsNNEEeSDLevdaFPXHw")]
    [DisplayName("Payment Schedule")]
    [IsoXmlTag("PmtSchdl")]
    public InterestPaymentDateRange1? PaymentSchedule { get; init; }

    /// <summary>
    /// Schedule of the shipment.
    /// </summary>
    [IsoId("_7q8k0NNEEeSDLevdaFPXHw")]
    [DisplayName("Shipment Schedule")]
    [IsoXmlTag("ShipmntSchdl")]
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; }

    /// <summary>
    /// Documents provided as attachments to the trade contract.
    /// </summary>
    [IsoId("_HyjhwdNDEeSDLevdaFPXHw")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public DocumentGeneralInformation3? Attachment { get; init; }
}
