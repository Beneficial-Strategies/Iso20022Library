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
[IsoId("_6R7xwbGIEeuSTr8k0UEM8A")]
[DisplayName("Trade Contract")]
public record TradeContract3
{
    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    [IsoId("_6SzUcbGIEeuSTr8k0UEM8A")]
    [DisplayName("Contract Document Identification")]
    [IsoXmlTag("CtrctDocId")]
    public DocumentIdentification22? ContractDocumentIdentification { get; init; }

    /// <summary>
    /// Type code of the trade contract.
    /// </summary>
    [IsoId("_ZRtPoLb6Eeu9Cp6InX88Vw")]
    [DisplayName("Trade Type Identification")]
    [IsoXmlTag("TradTpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TradeTypeIdentification { get; init; }

    /// <summary>
    /// Amount of the trade contract.
    /// </summary>
    [IsoId("_6SzUc7GIEeuSTr8k0UEM8A")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    [IsoId("_6SzUdbGIEeuSTr8k0UEM8A")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public ValueList<TradeParty5> Buyer { get; init; } = [];

    // ID for the above is _6SzUdbGIEeuSTr8k0UEM8A

    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    [IsoId("_6SzUd7GIEeuSTr8k0UEM8A")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public ValueList<TradeParty5> Seller { get; init; } = [];

    // ID for the above is _6SzUd7GIEeuSTr8k0UEM8A

    /// <summary>
    /// Planned final payment date at the time of issuance.
    /// </summary>
    [IsoId("_6SzUebGIEeuSTr8k0UEM8A")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// When absent, the flag meaning is NotApplicable.
    /// </summary>
    [IsoId("_6SzUe7GIEeuSTr8k0UEM8A")]
    [DisplayName("Prolongation Flag")]
    [IsoXmlTag("PrlngtnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ProlongationFlag { get; init; }

    /// <summary>
    /// Start date of the trade contract.
    /// </summary>
    [IsoId("_6SzUfbGIEeuSTr8k0UEM8A")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Currency in which the trade is being settled.
    /// </summary>
    [IsoId("_6SzUf7GIEeuSTr8k0UEM8A")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public ActiveCurrencyCode? SettlementCurrency { get; init; }

    /// <summary>
    /// Provides details on the currency exchange rate and contract.
    /// </summary>
    [IsoId("_6SzUgbGIEeuSTr8k0UEM8A")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Schedule of the payments defined for the trade contract.
    /// </summary>
    [IsoId("_6SzUg7GIEeuSTr8k0UEM8A")]
    [DisplayName("Payment Schedule")]
    [IsoXmlTag("PmtSchdl")]
    public InterestPaymentDateRange1? PaymentSchedule { get; init; }

    /// <summary>
    /// Schedule of the shipment.
    /// </summary>
    [IsoId("_6SzUhbGIEeuSTr8k0UEM8A")]
    [DisplayName("Shipment Schedule")]
    [IsoXmlTag("ShipmntSchdl")]
    public ShipmentSchedule2Choice_? ShipmentSchedule { get; init; }

    /// <summary>
    /// Documents provided as attachments to the trade contract.
    /// </summary>
    [IsoId("_6SzUh7GIEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public DocumentGeneralInformation5? Attachment { get; init; }
}
