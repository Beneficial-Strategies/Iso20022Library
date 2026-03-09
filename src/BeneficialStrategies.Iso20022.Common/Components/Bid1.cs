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
/// Attempt to buy or sell a large number of financial instruments contained in or comprising a portfolio.
/// </summary>
[IsoId("_S0Cy8Np-Ed-ak6NoX_4Aeg_34105770")]
[DisplayName("Bid")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Bid1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Bid1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Bid1( System.String reqClientBidIdentification,System.UInt64 reqTotalNumberSecurities,System.String reqExchangeForPhysicalIndicator,System.String reqForeignExchangeExecutionRequestedIndicator,TradeType2Code reqTradeType,BasisPriceType1Choice_ reqBasisPriceType,LiquidityAndStatistics1 reqLiquidityAndStatistics )
    {
        ClientBidIdentification = reqClientBidIdentification;
        TotalNumberSecurities = reqTotalNumberSecurities;
        ExchangeForPhysicalIndicator = reqExchangeForPhysicalIndicator;
        ForeignExchangeExecutionRequestedIndicator = reqForeignExchangeExecutionRequestedIndicator;
        TradeType = reqTradeType;
        BasisPriceType = reqBasisPriceType;
        LiquidityAndStatistics = reqLiquidityAndStatistics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a Bid Request as assigned by institution. Uniqueness must be guaranteed within a single trading day.
    /// </summary>
    [IsoId("_S0Cy8dp-Ed-ak6NoX_4Aeg_-2090576255")]
    [DisplayName("Client Bid Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntBidId")]
    #endif
    [IsoXmlTag("ClntBidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ClientBidIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClientBidIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClientBidIdentification { get; init; } 
    #else
    public System.String ClientBidIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the name of the order list.
    /// </summary>
    [IsoId("_S0Cy8tp-Ed-ak6NoX_4Aeg_337348509")]
    [DisplayName("List Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListNm")]
    #endif
    [IsoXmlTag("ListNm")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax128Text? ListName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ListName { get; init; } 
    #else
    public System.String? ListName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the bid.
    /// </summary>
    [IsoId("_S0Cy89p-Ed-ak6NoX_4Aeg_75666172")]
    [DisplayName("Bid Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BidId")]
    #endif
    [IsoXmlTag("BidId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BidIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BidIdentification { get; init; } 
    #else
    public System.String? BidIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of distinct financial instruments for which the bid is applicable.
    /// </summary>
    [IsoId("_S0Cy9Np-Ed-ak6NoX_4Aeg_590393890")]
    [DisplayName("Total Number Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbScties")]
    #endif
    [IsoXmlTag("TtlNbScties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TotalNumberSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumberSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumberSecurities { get; init; } 
    #else
    public System.UInt64 TotalNumberSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not to exchange for physical.
    /// </summary>
    [IsoId("_S0Cy9dp-Ed-ak6NoX_4Aeg_-549571304")]
    [DisplayName("Exchange For Physical Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgForPhysInd")]
    #endif
    [IsoXmlTag("XchgForPhysInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ExchangeForPhysicalIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExchangeForPhysicalIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExchangeForPhysicalIndicator { get; init; } 
    #else
    public System.String ExchangeForPhysicalIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a request for a foreign exchange accommodation trade to be executed along with security transaction.
    /// </summary>
    [IsoId("_S0Cy9tp-Ed-ak6NoX_4Aeg_1241941826")]
    [DisplayName("Foreign Exchange Execution Requested Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnXchgExctnReqdInd")]
    #endif
    [IsoXmlTag("FrgnXchgExctnReqdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ForeignExchangeExecutionRequestedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ForeignExchangeExecutionRequestedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ForeignExchangeExecutionRequestedIndicator { get; init; } 
    #else
    public System.String ForeignExchangeExecutionRequestedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of transaction of which the order is a component.
    /// </summary>
    [IsoId("_S0Cy99p-Ed-ak6NoX_4Aeg_878401922")]
    [DisplayName("Trade Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTp")]
    #endif
    [IsoXmlTag("TradTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeType2Code TradeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeType2Code TradeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeType2Code TradeType { get; init; } 
    #else
    public TradeType2Code TradeType { get; set; } 
    #endif
    
    /// <summary>
    /// Expected total number of tickets/allocations to be fully executed.
    /// </summary>
    [IsoId("_S0Cy-Np-Ed-ak6NoX_4Aeg_-456220346")]
    [DisplayName("Total Number Tickets")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbTckts")]
    #endif
    [IsoXmlTag("TtlNbTckts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberTickets { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberTickets { get; init; } 
    #else
    public System.UInt64? TotalNumberTickets { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the request to receive a report on the progress of the order or not.||A &apos;Yes&apos; value means a request for regular status messages to be sent.|A &apos;No&apos; value means no request to receive regular status messages.
    /// </summary>
    [IsoId("_S0Cy-dp-Ed-ak6NoX_4Aeg_682286749")]
    [DisplayName("Progress Report Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrgrsRptInd")]
    #endif
    [IsoXmlTag("PrgrsRptInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ProgressReportIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProgressReportIndicator { get; init; } 
    #else
    public System.String? ProgressReportIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the interval period in minutes between each ListStatus you wish to receive.
    /// </summary>
    [IsoId("_S0L84Np-Ed-ak6NoX_4Aeg_691521538")]
    [DisplayName("Progress Period Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrgrsPrdIntrvl")]
    #endif
    [IsoXmlTag("PrgrsPrdIntrvl")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? ProgressPeriodInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? ProgressPeriodInterval { get; init; } 
    #else
    public System.TimeOnly? ProgressPeriodInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the total number of bidders participating to a list trade.
    /// </summary>
    [IsoId("_S0L84dp-Ed-ak6NoX_4Aeg_2064797609")]
    [DisplayName("Total Number Of Bidders")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfBddrs")]
    #endif
    [IsoXmlTag("TtlNbOfBddrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberOfBidders { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberOfBidders { get; init; } 
    #else
    public System.UInt64? TotalNumberOfBidders { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_S0L84tp-Ed-ak6NoX_4Aeg_-1737930449")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TradeDate { get; init; } 
    #else
    public System.DateTime? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which current market prices are used to determine the value of a basket.
    /// </summary>
    [IsoId("_S0L85tp-Ed-ak6NoX_4Aeg_613820836")]
    [DisplayName("Strike Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkTm")]
    #endif
    [IsoXmlTag("StrkTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StrikeTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StrikeTime { get; init; } 
    #else
    public System.DateTime? StrikeTime { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the basis price type in a bid order (list trading).
    /// </summary>
    [IsoId("_S0L85Np-Ed-ak6NoX_4Aeg_-166177959")]
    [DisplayName("Basis Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisPricTp")]
    #endif
    [IsoXmlTag("BsisPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BasisPriceType1Choice_ BasisPriceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BasisPriceType1Choice_ BasisPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BasisPriceType1Choice_ BasisPriceType { get; init; } 
    #else
    public BasisPriceType1Choice_ BasisPriceType { get; set; } 
    #endif
    
    /// <summary>
    /// General details about the liquidity of the financial instrument.
    /// </summary>
    [IsoId("_S0L85dp-Ed-ak6NoX_4Aeg_1853639649")]
    [DisplayName("Liquidity And Statistics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdtyAndSttstcs")]
    #endif
    [IsoXmlTag("LqdtyAndSttstcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LiquidityAndStatistics1 LiquidityAndStatistics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LiquidityAndStatistics1 LiquidityAndStatistics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LiquidityAndStatistics1 LiquidityAndStatistics { get; init; } 
    #else
    public LiquidityAndStatistics1 LiquidityAndStatistics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
