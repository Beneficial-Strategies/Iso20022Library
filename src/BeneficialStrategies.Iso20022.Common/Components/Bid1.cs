// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attempt to buy or sell a large number of financial instruments contained in or comprising a portfolio.
/// </summary>
[IsoId("_S0Cy8Np-Ed-ak6NoX_4Aeg_34105770")]
[DisplayName("Bid")]
public partial record Bid1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a Bid Request as assigned by institution. Uniqueness must be guaranteed within a single trading day.
    /// </summary>
    [IsoId("_S0Cy8dp-Ed-ak6NoX_4Aeg_-2090576255")]
    [DisplayName("Client Bid Identification")]
    [IsoXmlTag("ClntBidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ClientBidIdentification { get; init; } 
    
    /// <summary>
    /// Provides the name of the order list.
    /// </summary>
    [IsoId("_S0Cy8tp-Ed-ak6NoX_4Aeg_337348509")]
    [DisplayName("List Name")]
    [IsoXmlTag("ListNm")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? ListName { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the bid.
    /// </summary>
    [IsoId("_S0Cy89p-Ed-ak6NoX_4Aeg_75666172")]
    [DisplayName("Bid Identification")]
    [IsoXmlTag("BidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BidIdentification { get; init; } 
    
    /// <summary>
    /// Total number of distinct financial instruments for which the bid is applicable.
    /// </summary>
    [IsoId("_S0Cy9Np-Ed-ak6NoX_4Aeg_590393890")]
    [DisplayName("Total Number Securities")]
    [IsoXmlTag("TtlNbScties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumberSecurities { get; init; } 
    
    /// <summary>
    /// Indicates whether or not to exchange for physical.
    /// </summary>
    [IsoId("_S0Cy9dp-Ed-ak6NoX_4Aeg_-549571304")]
    [DisplayName("Exchange For Physical Indicator")]
    [IsoXmlTag("XchgForPhysInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ExchangeForPhysicalIndicator { get; init; } 
    
    /// <summary>
    /// Indicates a request for a foreign exchange accommodation trade to be executed along with security transaction.
    /// </summary>
    [IsoId("_S0Cy9tp-Ed-ak6NoX_4Aeg_1241941826")]
    [DisplayName("Foreign Exchange Execution Requested Indicator")]
    [IsoXmlTag("FrgnXchgExctnReqdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForeignExchangeExecutionRequestedIndicator { get; init; } 
    
    /// <summary>
    /// Indicates the type of transaction of which the order is a component.
    /// </summary>
    [IsoId("_S0Cy99p-Ed-ak6NoX_4Aeg_878401922")]
    [DisplayName("Trade Type")]
    [IsoXmlTag("TradTp")]
    public required TradeType2Code TradeType { get; init; } 
    
    /// <summary>
    /// Expected total number of tickets/allocations to be fully executed.
    /// </summary>
    [IsoId("_S0Cy-Np-Ed-ak6NoX_4Aeg_-456220346")]
    [DisplayName("Total Number Tickets")]
    [IsoXmlTag("TtlNbTckts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberTickets { get; init; } 
    
    /// <summary>
    /// Identifies the request to receive a report on the progress of the order or not.||A &apos;Yes&apos; value means a request for regular status messages to be sent.|A &apos;No&apos; value means no request to receive regular status messages.
    /// </summary>
    [IsoId("_S0Cy-dp-Ed-ak6NoX_4Aeg_682286749")]
    [DisplayName("Progress Report Indicator")]
    [IsoXmlTag("PrgrsRptInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ProgressReportIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the interval period in minutes between each ListStatus you wish to receive.
    /// </summary>
    [IsoId("_S0L84Np-Ed-ak6NoX_4Aeg_691521538")]
    [DisplayName("Progress Period Interval")]
    [IsoXmlTag("PrgrsPrdIntrvl")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ProgressPeriodInterval { get; init; } 
    
    /// <summary>
    /// Indicates the total number of bidders participating to a list trade.
    /// </summary>
    [IsoId("_S0L84dp-Ed-ak6NoX_4Aeg_2064797609")]
    [DisplayName("Total Number Of Bidders")]
    [IsoXmlTag("TtlNbOfBddrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfBidders { get; init; } 
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_S0L84tp-Ed-ak6NoX_4Aeg_-1737930449")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TradeDate { get; init; } 
    
    /// <summary>
    /// Time at which current market prices are used to determine the value of a basket.
    /// </summary>
    [IsoId("_S0L85tp-Ed-ak6NoX_4Aeg_613820836")]
    [DisplayName("Strike Time")]
    [IsoXmlTag("StrkTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StrikeTime { get; init; } 
    
    /// <summary>
    /// Represents the basis price type in a bid order (list trading).
    /// </summary>
    [IsoId("_S0L85Np-Ed-ak6NoX_4Aeg_-166177959")]
    [DisplayName("Basis Price Type")]
    [IsoXmlTag("BsisPricTp")]
    public required BasisPriceType1Choice_ BasisPriceType { get; init; } 
    
    /// <summary>
    /// General details about the liquidity of the financial instrument.
    /// </summary>
    [IsoId("_S0L85dp-Ed-ak6NoX_4Aeg_1853639649")]
    [DisplayName("Liquidity And Statistics")]
    [IsoXmlTag("LqdtyAndSttstcs")]
    public required LiquidityAndStatistics1 LiquidityAndStatistics { get; init; } 
    
    
    #nullable disable
    
}
