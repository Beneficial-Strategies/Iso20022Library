// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer from one investment fund/fund class to another investment fund or investment fund class by the investor. A switch is composed of one or several subscription legs, and one or several redemption legs.
/// </summary>
[IsoId("_SMZkJ9p-Ed-ak6NoX_4Aeg_81412346")]
[DisplayName("Switch Order")]
public partial record SwitchOrder4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_SMZkKNp-Ed-ak6NoX_4Aeg_81412363")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; } 
    
    /// <summary>
    /// Date and time at which the order was placed by the investor.
    /// </summary>
    [IsoId("_SMZkKdp-Ed-ak6NoX_4Aeg_81412381")]
    [DisplayName("Order Date Time")]
    [IsoXmlTag("OrdrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? OrderDateTime { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SMZkKtp-Ed-ak6NoX_4Aeg_81412623")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_SMjVINp-Ed-ak6NoX_4Aeg_81412640")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientReference { get; init; } 
    
    /// <summary>
    /// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
    /// </summary>
    [IsoId("_SMjVIdp-Ed-ak6NoX_4Aeg_-1189165662")]
    [DisplayName("Investment Account Details")]
    [IsoXmlTag("InvstmtAcctDtls")]
    public InvestmentAccount21? InvestmentAccountDetails { get; init; } 
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be redeemed.
    /// </summary>
    [IsoId("_SMjVItp-Ed-ak6NoX_4Aeg_81412683")]
    [DisplayName("Total Redemption Amount")]
    [IsoXmlTag("TtlRedAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalRedemptionAmount { get; init; } 
    
    /// <summary>
    /// Amount of money used to derive the quantity of investment fund units to be subscribed.
    /// </summary>
    [IsoId("_SMjVI9p-Ed-ak6NoX_4Aeg_81412700")]
    [DisplayName("Total Subscription Amount")]
    [IsoXmlTag("TtlSbcptAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalSubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Future date at which the investor requests the order to be executed.|The specification of a requested future trade date is not allowed in some markets. The date must be a date in the future.
    /// </summary>
    [IsoId("_SMjVJNp-Ed-ak6NoX_4Aeg_-1825986571")]
    [DisplayName("Requested Future Trade Date")]
    [IsoXmlTag("ReqdFutrTradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedFutureTradeDate { get; init; } 
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    [IsoId("_SMjVJdp-Ed-ak6NoX_4Aeg_1050057608")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public ActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    [IsoId("_SMjVJtp-Ed-ak6NoX_4Aeg_1050057678")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CashSettlementDate { get; init; } 
    
    /// <summary>
    /// Method by which the transaction is settled.
    /// </summary>
    [IsoId("_SMjVJ9p-Ed-ak6NoX_4Aeg_1482215016")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public DeliveryReceiptType2Code? SettlementMethod { get; init; } 
    
    /// <summary>
    /// Date on which the order expires.
    /// </summary>
    [IsoId("_SMjVKNp-Ed-ak6NoX_4Aeg_81412718")]
    [DisplayName("Expiry Date Time")]
    [IsoXmlTag("XpryDtTm")]
    public DateAndDateTimeChoice_? ExpiryDateTime { get; init; } 
    
    /// <summary>
    /// Additional amount of money paid by the investor in addition to the switch redemption amount.
    /// </summary>
    [IsoId("_SMjVKdp-Ed-ak6NoX_4Aeg_81412735")]
    [DisplayName("Additional Cash In")]
    [IsoXmlTag("AddtlCshIn")]
    public ActiveOrHistoricCurrencyAndAmount? AdditionalCashIn { get; init; } 
    
    /// <summary>
    /// Amount of money that results from a switch-out, that is not reinvested in another investment fund, and is repaid to the investor.
    /// </summary>
    [IsoId("_SMtGINp-Ed-ak6NoX_4Aeg_81412753")]
    [DisplayName("Resulting Cash Out")]
    [IsoXmlTag("RsltgCshOut")]
    public ActiveOrHistoricCurrencyAndAmount? ResultingCashOut { get; init; } 
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_SMtGIdp-Ed-ak6NoX_4Aeg_952308355")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SMtGItp-Ed-ak6NoX_4Aeg_81412778")]
    [DisplayName("Cancellation Right")]
    [IsoXmlTag("CxlRght")]
    public CancellationRight1Code? CancellationRight { get; init; } 
    
    /// <summary>
    /// Cancellation right of an investor with respect to an investment fund order.
    /// </summary>
    [IsoId("_SMtGI9p-Ed-ak6NoX_4Aeg_81413156")]
    [DisplayName("Extended Cancellation Right")]
    [IsoXmlTag("XtndedCxlRght")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCancellationRight { get; init; } 
    
    /// <summary>
    /// Part of an investment fund switch order that is a redemption.
    /// </summary>
    [IsoId("_SMtGJNp-Ed-ak6NoX_4Aeg_81413337")]
    [DisplayName("Redemption Leg Details")]
    [IsoXmlTag("RedLegDtls")]
    public ValueList<SwitchRedemptionLegOrder3> RedemptionLegDetails { get; init; } = [];
    // ID for the above is _SMtGJNp-Ed-ak6NoX_4Aeg_81413337
    
    /// <summary>
    /// Part of an investment fund switch order that is a subscription.
    /// </summary>
    [IsoId("_SMtGJdp-Ed-ak6NoX_4Aeg_81413259")]
    [DisplayName("Subscription Leg Details")]
    [IsoXmlTag("SbcptLegDtls")]
    public ValueList<SwitchSubscriptionLegOrder3> SubscriptionLegDetails { get; init; } = [];
    // ID for the above is _SMtGJdp-Ed-ak6NoX_4Aeg_81413259
    
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_SMtGJtp-Ed-ak6NoX_4Aeg_81413631")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentTransaction25? CashSettlementDetails { get; init; } 
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_SMtGJ9p-Ed-ak6NoX_4Aeg_81413182")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Specifies if advice has been received from an independent financial advisor.
    /// </summary>
    [IsoId("_SMtGKNp-Ed-ak6NoX_4Aeg_-677384579")]
    [DisplayName("Financial Advice")]
    [IsoXmlTag("FinAdvc")]
    public FinancialAdvice1Code? FinancialAdvice { get; init; } 
    
    /// <summary>
    /// Specifies whether the trade is negotiated.
    /// </summary>
    [IsoId("_SMtGKdp-Ed-ak6NoX_4Aeg_1066726053")]
    [DisplayName("Negotiated Trade")]
    [IsoXmlTag("NgtdTrad")]
    public NegotiatedTrade1Code? NegotiatedTrade { get; init; } 
    
    
    #nullable disable
    
}
