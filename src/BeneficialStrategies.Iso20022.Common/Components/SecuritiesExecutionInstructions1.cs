// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the instructions for order handling.
/// </summary>
[IsoId("_Tq4UXNp-Ed-ak6NoX_4Aeg_867867766")]
[DisplayName("Securities Execution Instructions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesExecutionInstructions1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Round-lot market or limit-price order that must be executed in its entirety or not at all; unlike Fill or Kill orders, AON orders are not treated as canceled if they are not executed as soon as represented in the Trading Crowd.
    /// </summary>
    [IsoId("_TrBeQNp-Ed-ak6NoX_4Aeg_1554042022")]
    [DisplayName("All Or None")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllOrNn")]
    #endif
    [IsoXmlTag("AllOrNn")]
    [IsoSimpleType(IsoSimpleType.AllOrNoneIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAllOrNoneIndicator? AllOrNone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllOrNone { get; init; } 
    #else
    public System.String? AllOrNone { get; set; } 
    #endif
    
    /// <summary>
    /// Refers to the client before trading in order to catch all verbal instructions on trading strategy usually because the strategy is too complex or cannot be represented in the trading application.
    /// </summary>
    [IsoId("_TrBeQdp-Ed-ak6NoX_4Aeg_1554042057")]
    [DisplayName("Call First")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallFrst")]
    #endif
    [IsoXmlTag("CallFrst")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CallFirst { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CallFirst { get; init; } 
    #else
    public System.String? CallFirst { get; set; } 
    #endif
    
    /// <summary>
    /// Allow crossing of an order.
    /// </summary>
    [IsoId("_TrBeQtp-Ed-ak6NoX_4Aeg_1554042082")]
    [DisplayName("Cross")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cross")]
    #endif
    [IsoXmlTag("Cross")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Cross { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Cross { get; init; } 
    #else
    public System.String? Cross { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange or ECN required by the SEC to display limit orders in the public order book. A customer can choose not to have his limit order displayed to the public.
    /// </summary>
    [IsoId("_TrBeQ9p-Ed-ak6NoX_4Aeg_1554042365")]
    [DisplayName("Customer Display")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrDisp")]
    #endif
    [IsoXmlTag("CstmrDisp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CustomerDisplay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerDisplay { get; init; } 
    #else
    public System.String? CustomerDisplay { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the firm executing the order is held to best execution requirements and may be able to make some discretionary decisions.
    /// </summary>
    [IsoId("_TrBeRNp-Ed-ak6NoX_4Aeg_1554042425")]
    [DisplayName("Hold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hld")]
    #endif
    [IsoXmlTag("Hld")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Hold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Hold { get; init; } 
    #else
    public System.String? Hold { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the order is to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.
    /// </summary>
    [IsoId("_TrBeRdp-Ed-ak6NoX_4Aeg_1554042460")]
    [DisplayName("Increase")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incr")]
    #endif
    [IsoXmlTag("Incr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Increase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Increase { get; init; } 
    #else
    public System.String? Increase { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies that the broker is restricted to dealing with other buy side firms.
    /// </summary>
    [IsoId("_TrBeRtp-Ed-ak6NoX_4Aeg_1554042503")]
    [DisplayName("Institutions Only")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstnsOnly")]
    #endif
    [IsoXmlTag("InstnsOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InstitutionsOnly { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstitutionsOnly { get; init; } 
    #else
    public System.String? InstitutionsOnly { get; set; } 
    #endif
    
    /// <summary>
    /// Qualifies an asset (usually a payment instrument) of which rights cannot be transferred to a party other then the original debtor and creditor.
    /// </summary>
    [IsoId("_TrBeR9p-Ed-ak6NoX_4Aeg_1554042521")]
    [DisplayName("Non Negotiable")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonNgtbl")]
    #endif
    [IsoXmlTag("NonNgtbl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NonNegotiable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonNegotiable { get; init; } 
    #else
    public System.String? NonNegotiable { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether to execute parts of the order over the course of the day. Usually done with large block orders.
    /// </summary>
    [IsoId("_TrBeSNp-Ed-ak6NoX_4Aeg_1554042563")]
    [DisplayName("Over The Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverTheDay")]
    #endif
    [IsoXmlTag("OverTheDay")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? OverTheDay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OverTheDay { get; init; } 
    #else
    public System.String? OverTheDay { get; set; } 
    #endif
    
    /// <summary>
    /// An order that may participate in a transaction initiated by another party, but may not initiate a transaction.
    /// </summary>
    [IsoId("_TrBeSdp-Ed-ak6NoX_4Aeg_1554042598")]
    [DisplayName("Participate Dont Initiate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcpDontInit")]
    #endif
    [IsoXmlTag("PtcpDontInit")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ParticipateDontInitiate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ParticipateDontInitiate { get; init; } 
    #else
    public System.String? ParticipateDontInitiate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the Sender does not want all of the volume on the floor.
    /// </summary>
    [IsoId("_TrLPQNp-Ed-ak6NoX_4Aeg_1554042893")]
    [DisplayName("Percent Of Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctOfVol")]
    #endif
    [IsoXmlTag("PctOfVol")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PercentOfVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PercentOfVolume { get; init; } 
    #else
    public System.String? PercentOfVolume { get; set; } 
    #endif
    
    /// <summary>
    /// An order to buy (or sell) a financial instrument which specifies the total amount to be bought (or sold) and the amount to be bought (or sold) at specified price variations.
    /// </summary>
    [IsoId("_TrLPQdp-Ed-ak6NoX_4Aeg_1554042935")]
    [DisplayName("Scale")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scale")]
    #endif
    [IsoXmlTag("Scale")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Scale { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Scale { get; init; } 
    #else
    public System.String? Scale { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the order limit based on the offer/bid at the time of the order submission.
    /// </summary>
    [IsoId("_TrLPQtp-Ed-ak6NoX_4Aeg_1554042970")]
    [DisplayName("Stay On Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StayOnSd")]
    #endif
    [IsoXmlTag("StayOnSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StayOnSideType1Code? StayOnSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StayOnSideType1Code? StayOnSide { get; init; } 
    #else
    public StayOnSideType1Code? StayOnSide { get; set; } 
    #endif
    
    /// <summary>
    /// Make the order active until notified.
    /// </summary>
    [IsoId("_TrLPQ9p-Ed-ak6NoX_4Aeg_1554043013")]
    [DisplayName("Work")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Work")]
    #endif
    [IsoXmlTag("Work")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Work { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Work { get; init; } 
    #else
    public System.String? Work { get; set; } 
    #endif
    
    /// <summary>
    /// Used for listed equity securities. Buy or sell at prices that randomly occur on the floor, participating in what|trades the specialist and other players will allow.
    /// </summary>
    [IsoId("_TrLPRNp-Ed-ak6NoX_4Aeg_1554043048")]
    [DisplayName("Go Along")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoAlong")]
    #endif
    [IsoXmlTag("GoAlong")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? GoAlong { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GoAlong { get; init; } 
    #else
    public System.String? GoAlong { get; set; } 
    #endif
    
    /// <summary>
    /// Order to buy (sell) a security that specifies the total amount to be bought (sold) and the amount to be bought (sold) at successively decreasing (increasing) price intervals; often placed in order to average the price.
    /// </summary>
    [IsoId("_TrLPRdp-Ed-ak6NoX_4Aeg_1554043373")]
    [DisplayName("Try Scale")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TryScale")]
    #endif
    [IsoXmlTag("TryScale")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TryScale { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TryScale { get; init; } 
    #else
    public System.String? TryScale { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether to buy, to stop order to sell, or to stop limit order to sell that is not to be reduced in price by the amount of an ordinary cash dividend on the ex-dividend date. A &quot;do not reduce&quot; order applies only to ordinary cash dividends; it should be reduced for other distributions - such as when a stock goes ex stock dividend or ex rights.
    /// </summary>
    [IsoId("_TrLPRtp-Ed-ak6NoX_4Aeg_1554043416")]
    [DisplayName("Do Not Reduce")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DoNotRdc")]
    #endif
    [IsoXmlTag("DoNotRdc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DoNotReduce { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DoNotReduce { get; init; } 
    #else
    public System.String? DoNotReduce { get; set; } 
    #endif
    
    /// <summary>
    /// If a system failure interrupts trading or order routing, attempt to cancel this order and attempt to reinstate this order, subject to time in force limitations. Note that depending on the type and severity of the failure, this might not be possible.
    /// </summary>
    [IsoId("_TrLPR9p-Ed-ak6NoX_4Aeg_1554043451")]
    [DisplayName("Cancel On System Failure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CclOnSysFailr")]
    #endif
    [IsoXmlTag("CclOnSysFailr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CancelOnSystemFailure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancelOnSystemFailure { get; init; } 
    #else
    public System.String? CancelOnSystemFailure { get; set; } 
    #endif
    
    /// <summary>
    /// If trading in this instrument is halted, cancel this order and reinstate this order when/if trading resumes, subject to time in force limitations.
    /// </summary>
    [IsoId("_TrLPSNp-Ed-ak6NoX_4Aeg_1554043493")]
    [DisplayName("Cancel On Trading Halt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CclOnTradgHalt")]
    #endif
    [IsoXmlTag("CclOnTradgHalt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CancelOnTradingHalt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancelOnTradingHalt { get; init; } 
    #else
    public System.String? CancelOnTradingHalt { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the broker has permission to handle and place the order in the market even if the broker already has its own proprietary orders for the same financial instrument placed in the market.
    /// </summary>
    [IsoId("_TrLPSdp-Ed-ak6NoX_4Aeg_1554043588")]
    [DisplayName("Trade Along")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAlong")]
    #endif
    [IsoXmlTag("TradAlong")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TradeAlong { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeAlong { get; init; } 
    #else
    public System.String? TradeAlong { get; set; } 
    #endif
    
    /// <summary>
    /// Limit order that must be traded at the exact limit price specified without any price improvement.
    /// </summary>
    [IsoId("_TrVAQNp-Ed-ak6NoX_4Aeg_2003362450")]
    [DisplayName("Strict Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrctLmt")]
    #endif
    [IsoXmlTag("StrctLmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? StrictLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StrictLimit { get; init; } 
    #else
    public System.String? StrictLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Disables validity checking of price fields for an order or change request.
    /// </summary>
    [IsoId("_TrVAQdp-Ed-ak6NoX_4Aeg_2003363104")]
    [DisplayName("Ignore Price Validity Checks")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IgnrPricVldtyChcks")]
    #endif
    [IsoXmlTag("IgnrPricVldtyChcks")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? IgnorePriceValidityChecks { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IgnorePriceValidityChecks { get; init; } 
    #else
    public System.String? IgnorePriceValidityChecks { get; set; } 
    #endif
    
    /// <summary>
    /// If a system failure interrupts trading or order routing, attempt to reinstate this order, subject to time in force limitations. Depending on the type and severity of the failure, this might not be possible.
    /// </summary>
    [IsoId("_TrVAQtp-Ed-ak6NoX_4Aeg_2003363476")]
    [DisplayName("Reinstate On System Failure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinsttOnSysFailr")]
    #endif
    [IsoXmlTag("RinsttOnSysFailr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ReinstateOnSystemFailure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReinstateOnSystemFailure { get; init; } 
    #else
    public System.String? ReinstateOnSystemFailure { get; set; } 
    #endif
    
    /// <summary>
    /// If trading in this instrument is halted, reinstate this order when/if trading resumes, subject to time in force limitations.
    /// </summary>
    [IsoId("_TrVAQ9p-Ed-ak6NoX_4Aeg_2003363844")]
    [DisplayName("Reinstate On Trading Halt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinsttOnTradgHalt")]
    #endif
    [IsoXmlTag("RinsttOnTradgHalt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ReinstateOnTradingHalt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReinstateOnTradingHalt { get; init; } 
    #else
    public System.String? ReinstateOnTradingHalt { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that an order should be cancelled if it is no longer the best bid if buying, or the best offer if selling.
    /// </summary>
    [IsoId("_TrVARNp-Ed-ak6NoX_4Aeg_2003364016")]
    [DisplayName("Cancel If Not Best")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CclIfNotBest")]
    #endif
    [IsoXmlTag("CclIfNotBest")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CancelIfNotBest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancelIfNotBest { get; init; } 
    #else
    public System.String? CancelIfNotBest { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that an order sent to one market may be routed by that market to other external markets, especially in cases where the order locks or crosses the market and it can be executed against another markets superior price. The absence of this instruction does not imply that an order should not be routed externally; rather, the order receivers default will apply.
    /// </summary>
    [IsoId("_TrVARdp-Ed-ak6NoX_4Aeg_2003364346")]
    [DisplayName("External Routing Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRtgAllwd")]
    #endif
    [IsoXmlTag("XtrnlRtgAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ExternalRoutingAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExternalRoutingAllowed { get; init; } 
    #else
    public System.String? ExternalRoutingAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that an order sent to one market may never be routed by that market to other external markets. Should the order lock or cross the market but be unable to execute due to price protection reasons, a market may have to take alternate action, which might include rejecting the order, depending on the markets rules.The absence of this instruction does not imply that an order should be routed externally; rather, the order receivers default will apply.
    /// </summary>
    [IsoId("_TrVARtp-Ed-ak6NoX_4Aeg_2003364466")]
    [DisplayName("External Routing Not Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtrnlRtgNotAllwd")]
    #endif
    [IsoXmlTag("XtrnlRtgNotAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ExternalRoutingNotAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExternalRoutingNotAllowed { get; init; } 
    #else
    public System.String? ExternalRoutingNotAllowed { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the order can only hit the imbalance during a call auction. The imbalance is the remaining quantity when other buy and sell orders are matched at the auction clearing price.
    /// </summary>
    [IsoId("_TrVAR9p-Ed-ak6NoX_4Aeg_2003364844")]
    [DisplayName("Imbalance Only")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImbalOnly")]
    #endif
    [IsoXmlTag("ImbalOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ImbalanceOnly { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ImbalanceOnly { get; init; } 
    #else
    public System.String? ImbalanceOnly { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the party sending the order has taken responsibility for price protection, and the recipient of the order should execute it, if possible, without regard to protection of other markets prices. While the term &quot;Intermarket sweep&quot; is specific to the United States, it may be used in other markets, where appropriate, to indicate an order that should be executed without regard to price protection.
    /// </summary>
    [IsoId("_TrVASNp-Ed-ak6NoX_4Aeg_2003364964")]
    [DisplayName("Intermarket Sweep")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmktSweep")]
    #endif
    [IsoXmlTag("IntrmktSweep")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? IntermarketSweep { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntermarketSweep { get; init; } 
    #else
    public System.String? IntermarketSweep { get; set; } 
    #endif
    
    /// <summary>
    /// Used when sending multiple orders indicating that you would be &apos;netting&apos; the F/X later.
    /// </summary>
    [IsoId("_TrVASdp-Ed-ak6NoX_4Aeg_2003365336")]
    [DisplayName("Netting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Netg")]
    #endif
    [IsoXmlTag("Netg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Netting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Netting { get; init; } 
    #else
    public System.String? Netting { get; set; } 
    #endif
    
    
    #nullable disable
    
}
