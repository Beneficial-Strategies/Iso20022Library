// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Foreign Exchange Trade1.
/// </summary>
[IsoId("_s3KhkOtxEe6GDu6DljhDaQ")]
[DisplayName("Foreign Exchange Trade1")]
public partial record ForeignExchangeTrade1
{
    #nullable enable

    /// <summary>
    /// Agreed Rate.
    /// </summary>
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("")]
    public required CurrencyExchange25 AgreedRate { get; init; } 

    /// <summary>
    /// Block Indicator.
    /// </summary>
    [DisplayName("Block Indicator")]
    [IsoXmlTag("")]
    public IsoYesNoIndicator? BlockIndicator { get; init; } 

    /// <summary>
    /// Broker Commission.
    /// </summary>
    [DisplayName("Broker Commission")]
    [IsoXmlTag("")]
    public CurrencyAndAmount? BrokerCommission { get; init; } 

    /// <summary>
    /// Brokers Reference.
    /// </summary>
    [DisplayName("Brokers Reference")]
    [IsoXmlTag("")]
    public IsoMax35Text? BrokersReference { get; init; } 

    /// <summary>
    /// Buy Amount.
    /// </summary>
    [DisplayName("Buy Amount")]
    [IsoXmlTag("")]
    public required CurrencyAndAmount BuyAmount { get; init; } 

    /// <summary>
    /// Definitions Year.
    /// </summary>
    [DisplayName("Definitions Year")]
    [IsoXmlTag("")]
    public IsoISOYear? DefinitionsYear { get; init; } 

    /// <summary>
    /// Governing Document.
    /// </summary>
    [DisplayName("Governing Document")]
    [IsoXmlTag("")]
    public AgreementConditions1? GoverningDocument { get; init; } 

    /// <summary>
    /// Non Deliverable Indicator.
    /// </summary>
    [DisplayName("Non Deliverable Indicator")]
    [IsoXmlTag("")]
    public SpecialPurposeCode? NonDeliverableIndicator { get; init; } 

    /// <summary>
    /// Non Deliverable Trade.
    /// </summary>
    [DisplayName("Non Deliverable Trade")]
    [IsoXmlTag("")]
    public NonDeliverableTrade1? NonDeliverableTrade { get; init; } 

    /// <summary>
    /// Payment Versus Payment Indicator.
    /// </summary>
    [DisplayName("Payment Versus Payment Indicator")]
    [IsoXmlTag("")]
    public IsoYesNoIndicator? PaymentVersusPaymentIndicator { get; init; } 

    /// <summary>
    /// Sell Amount.
    /// </summary>
    [DisplayName("Sell Amount")]
    [IsoXmlTag("")]
    public required CurrencyAndAmount SellAmount { get; init; } 

    /// <summary>
    /// Terms And Conditions.
    /// </summary>
    [DisplayName("Terms And Conditions")]
    [IsoXmlTag("")]
    public IsoMax210Text? TermsAndConditions { get; init; } 

    /// <summary>
    /// Trade Date Time.
    /// </summary>
    [DisplayName("Trade Date Time")]
    [IsoXmlTag("")]
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 

    /// <summary>
    /// Trade Party.
    /// </summary>
    [DisplayName("Trade Party")]
    [IsoXmlTag("")]
    public ValueList<TradeParty7> TradeParty { get; init; } = [];

    /// <summary>
    /// Trading Method.
    /// </summary>
    [DisplayName("Trading Method")]
    [IsoXmlTag("")]
    public TradingMethodCode? TradingMethod { get; init; } 

    /// <summary>
    /// Trading Party Capacity.
    /// </summary>
    [DisplayName("Trading Party Capacity")]
    [IsoXmlTag("")]
    public TradingCapacity9Code? TradingPartyCapacity { get; init; } 

    /// <summary>
    /// Value Date.
    /// </summary>
    [DisplayName("Value Date")]
    [IsoXmlTag("")]
    public required IsoISODate ValueDate { get; init; } 

    
    #nullable disable
    
}
