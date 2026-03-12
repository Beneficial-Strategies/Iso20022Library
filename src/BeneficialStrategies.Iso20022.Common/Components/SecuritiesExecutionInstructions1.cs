// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the instructions for order handling.
/// </summary>
[IsoId("_Tq4UXNp-Ed-ak6NoX_4Aeg_867867766")]
[DisplayName("Securities Execution Instructions")]
public partial record SecuritiesExecutionInstructions1
{
    #nullable enable
    
    /// <summary>
    /// Round-lot market or limit-price order that must be executed in its entirety or not at all; unlike Fill or Kill orders, AON orders are not treated as canceled if they are not executed as soon as represented in the Trading Crowd.
    /// </summary>
    [IsoId("_TrBeQNp-Ed-ak6NoX_4Aeg_1554042022")]
    [DisplayName("All Or None")]
    [IsoXmlTag("AllOrNn")]
    [IsoSimpleType(IsoSimpleType.AllOrNoneIndicator)]
    public IsoAllOrNoneIndicator? AllOrNone { get; init; } 
    
    /// <summary>
    /// Refers to the client before trading in order to catch all verbal instructions on trading strategy usually because the strategy is too complex or cannot be represented in the trading application.
    /// </summary>
    [IsoId("_TrBeQdp-Ed-ak6NoX_4Aeg_1554042057")]
    [DisplayName("Call First")]
    [IsoXmlTag("CallFrst")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallFirst { get; init; } 
    
    /// <summary>
    /// Allow crossing of an order.
    /// </summary>
    [IsoId("_TrBeQtp-Ed-ak6NoX_4Aeg_1554042082")]
    [DisplayName("Cross")]
    [IsoXmlTag("Cross")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Cross { get; init; } 
    
    /// <summary>
    /// Exchange or ECN required by the SEC to display limit orders in the public order book. A customer can choose not to have his limit order displayed to the public.
    /// </summary>
    [IsoId("_TrBeQ9p-Ed-ak6NoX_4Aeg_1554042365")]
    [DisplayName("Customer Display")]
    [IsoXmlTag("CstmrDisp")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CustomerDisplay { get; init; } 
    
    /// <summary>
    /// Indicates whether the firm executing the order is held to best execution requirements and may be able to make some discretionary decisions.
    /// </summary>
    [IsoId("_TrBeRNp-Ed-ak6NoX_4Aeg_1554042425")]
    [DisplayName("Hold")]
    [IsoXmlTag("Hld")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Hold { get; init; } 
    
    /// <summary>
    /// Indicates whether the order is to be increased in shares on the ex-dividend date as a result of a stock dividend or distribution.
    /// </summary>
    [IsoId("_TrBeRdp-Ed-ak6NoX_4Aeg_1554042460")]
    [DisplayName("Increase")]
    [IsoXmlTag("Incr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Increase { get; init; } 
    
    /// <summary>
    /// Identifies that the broker is restricted to dealing with other buy side firms.
    /// </summary>
    [IsoId("_TrBeRtp-Ed-ak6NoX_4Aeg_1554042503")]
    [DisplayName("Institutions Only")]
    [IsoXmlTag("InstnsOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InstitutionsOnly { get; init; } 
    
    /// <summary>
    /// Qualifies an asset (usually a payment instrument) of which rights cannot be transferred to a party other then the original debtor and creditor.
    /// </summary>
    [IsoId("_TrBeR9p-Ed-ak6NoX_4Aeg_1554042521")]
    [DisplayName("Non Negotiable")]
    [IsoXmlTag("NonNgtbl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NonNegotiable { get; init; } 
    
    /// <summary>
    /// Indicates whether to execute parts of the order over the course of the day. Usually done with large block orders.
    /// </summary>
    [IsoId("_TrBeSNp-Ed-ak6NoX_4Aeg_1554042563")]
    [DisplayName("Over The Day")]
    [IsoXmlTag("OverTheDay")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? OverTheDay { get; init; } 
    
    /// <summary>
    /// An order that may participate in a transaction initiated by another party, but may not initiate a transaction.
    /// </summary>
    [IsoId("_TrBeSdp-Ed-ak6NoX_4Aeg_1554042598")]
    [DisplayName("Participate Dont Initiate")]
    [IsoXmlTag("PtcpDontInit")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ParticipateDontInitiate { get; init; } 
    
    /// <summary>
    /// Indicates that the Sender does not want all of the volume on the floor.
    /// </summary>
    [IsoId("_TrLPQNp-Ed-ak6NoX_4Aeg_1554042893")]
    [DisplayName("Percent Of Volume")]
    [IsoXmlTag("PctOfVol")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PercentOfVolume { get; init; } 
    
    /// <summary>
    /// An order to buy (or sell) a financial instrument which specifies the total amount to be bought (or sold) and the amount to be bought (or sold) at specified price variations.
    /// </summary>
    [IsoId("_TrLPQdp-Ed-ak6NoX_4Aeg_1554042935")]
    [DisplayName("Scale")]
    [IsoXmlTag("Scale")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Scale { get; init; } 
    
    /// <summary>
    /// Specifies the order limit based on the offer/bid at the time of the order submission.
    /// </summary>
    [IsoId("_TrLPQtp-Ed-ak6NoX_4Aeg_1554042970")]
    [DisplayName("Stay On Side")]
    [IsoXmlTag("StayOnSd")]
    public StayOnSideType1Code? StayOnSide { get; init; } 
    
    /// <summary>
    /// Make the order active until notified.
    /// </summary>
    [IsoId("_TrLPQ9p-Ed-ak6NoX_4Aeg_1554043013")]
    [DisplayName("Work")]
    [IsoXmlTag("Work")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Work { get; init; } 
    
    /// <summary>
    /// Used for listed equity securities. Buy or sell at prices that randomly occur on the floor, participating in what|trades the specialist and other players will allow.
    /// </summary>
    [IsoId("_TrLPRNp-Ed-ak6NoX_4Aeg_1554043048")]
    [DisplayName("Go Along")]
    [IsoXmlTag("GoAlong")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? GoAlong { get; init; } 
    
    /// <summary>
    /// Order to buy (sell) a security that specifies the total amount to be bought (sold) and the amount to be bought (sold) at successively decreasing (increasing) price intervals; often placed in order to average the price.
    /// </summary>
    [IsoId("_TrLPRdp-Ed-ak6NoX_4Aeg_1554043373")]
    [DisplayName("Try Scale")]
    [IsoXmlTag("TryScale")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TryScale { get; init; } 
    
    /// <summary>
    /// Indicates whether to buy, to stop order to sell, or to stop limit order to sell that is not to be reduced in price by the amount of an ordinary cash dividend on the ex-dividend date. A &quot;do not reduce&quot; order applies only to ordinary cash dividends; it should be reduced for other distributions - such as when a stock goes ex stock dividend or ex rights.
    /// </summary>
    [IsoId("_TrLPRtp-Ed-ak6NoX_4Aeg_1554043416")]
    [DisplayName("Do Not Reduce")]
    [IsoXmlTag("DoNotRdc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DoNotReduce { get; init; } 
    
    /// <summary>
    /// If a system failure interrupts trading or order routing, attempt to cancel this order and attempt to reinstate this order, subject to time in force limitations. Note that depending on the type and severity of the failure, this might not be possible.
    /// </summary>
    [IsoId("_TrLPR9p-Ed-ak6NoX_4Aeg_1554043451")]
    [DisplayName("Cancel On System Failure")]
    [IsoXmlTag("CclOnSysFailr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CancelOnSystemFailure { get; init; } 
    
    /// <summary>
    /// If trading in this instrument is halted, cancel this order and reinstate this order when/if trading resumes, subject to time in force limitations.
    /// </summary>
    [IsoId("_TrLPSNp-Ed-ak6NoX_4Aeg_1554043493")]
    [DisplayName("Cancel On Trading Halt")]
    [IsoXmlTag("CclOnTradgHalt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CancelOnTradingHalt { get; init; } 
    
    /// <summary>
    /// Indicates whether the broker has permission to handle and place the order in the market even if the broker already has its own proprietary orders for the same financial instrument placed in the market.
    /// </summary>
    [IsoId("_TrLPSdp-Ed-ak6NoX_4Aeg_1554043588")]
    [DisplayName("Trade Along")]
    [IsoXmlTag("TradAlong")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TradeAlong { get; init; } 
    
    /// <summary>
    /// Limit order that must be traded at the exact limit price specified without any price improvement.
    /// </summary>
    [IsoId("_TrVAQNp-Ed-ak6NoX_4Aeg_2003362450")]
    [DisplayName("Strict Limit")]
    [IsoXmlTag("StrctLmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? StrictLimit { get; init; } 
    
    /// <summary>
    /// Disables validity checking of price fields for an order or change request.
    /// </summary>
    [IsoId("_TrVAQdp-Ed-ak6NoX_4Aeg_2003363104")]
    [DisplayName("Ignore Price Validity Checks")]
    [IsoXmlTag("IgnrPricVldtyChcks")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? IgnorePriceValidityChecks { get; init; } 
    
    /// <summary>
    /// If a system failure interrupts trading or order routing, attempt to reinstate this order, subject to time in force limitations. Depending on the type and severity of the failure, this might not be possible.
    /// </summary>
    [IsoId("_TrVAQtp-Ed-ak6NoX_4Aeg_2003363476")]
    [DisplayName("Reinstate On System Failure")]
    [IsoXmlTag("RinsttOnSysFailr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReinstateOnSystemFailure { get; init; } 
    
    /// <summary>
    /// If trading in this instrument is halted, reinstate this order when/if trading resumes, subject to time in force limitations.
    /// </summary>
    [IsoId("_TrVAQ9p-Ed-ak6NoX_4Aeg_2003363844")]
    [DisplayName("Reinstate On Trading Halt")]
    [IsoXmlTag("RinsttOnTradgHalt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReinstateOnTradingHalt { get; init; } 
    
    /// <summary>
    /// Indicates that an order should be cancelled if it is no longer the best bid if buying, or the best offer if selling.
    /// </summary>
    [IsoId("_TrVARNp-Ed-ak6NoX_4Aeg_2003364016")]
    [DisplayName("Cancel If Not Best")]
    [IsoXmlTag("CclIfNotBest")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CancelIfNotBest { get; init; } 
    
    /// <summary>
    /// Indicates that an order sent to one market may be routed by that market to other external markets, especially in cases where the order locks or crosses the market and it can be executed against another markets superior price. The absence of this instruction does not imply that an order should not be routed externally; rather, the order receivers default will apply.
    /// </summary>
    [IsoId("_TrVARdp-Ed-ak6NoX_4Aeg_2003364346")]
    [DisplayName("External Routing Allowed")]
    [IsoXmlTag("XtrnlRtgAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExternalRoutingAllowed { get; init; } 
    
    /// <summary>
    /// Indicates that an order sent to one market may never be routed by that market to other external markets. Should the order lock or cross the market but be unable to execute due to price protection reasons, a market may have to take alternate action, which might include rejecting the order, depending on the markets rules.The absence of this instruction does not imply that an order should be routed externally; rather, the order receivers default will apply.
    /// </summary>
    [IsoId("_TrVARtp-Ed-ak6NoX_4Aeg_2003364466")]
    [DisplayName("External Routing Not Allowed")]
    [IsoXmlTag("XtrnlRtgNotAllwd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExternalRoutingNotAllowed { get; init; } 
    
    /// <summary>
    /// Indicates that the order can only hit the imbalance during a call auction. The imbalance is the remaining quantity when other buy and sell orders are matched at the auction clearing price.
    /// </summary>
    [IsoId("_TrVAR9p-Ed-ak6NoX_4Aeg_2003364844")]
    [DisplayName("Imbalance Only")]
    [IsoXmlTag("ImbalOnly")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ImbalanceOnly { get; init; } 
    
    /// <summary>
    /// Indicates that the party sending the order has taken responsibility for price protection, and the recipient of the order should execute it, if possible, without regard to protection of other markets prices. While the term &quot;Intermarket sweep&quot; is specific to the United States, it may be used in other markets, where appropriate, to indicate an order that should be executed without regard to price protection.
    /// </summary>
    [IsoId("_TrVASNp-Ed-ak6NoX_4Aeg_2003364964")]
    [DisplayName("Intermarket Sweep")]
    [IsoXmlTag("IntrmktSweep")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? IntermarketSweep { get; init; } 
    
    /// <summary>
    /// Used when sending multiple orders indicating that you would be &apos;netting&apos; the F/X later.
    /// </summary>
    [IsoId("_TrVASdp-Ed-ak6NoX_4Aeg_2003365336")]
    [DisplayName("Netting")]
    [IsoXmlTag("Netg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Netting { get; init; } 
    
    
    #nullable disable
    
}
