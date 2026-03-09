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
/// Query criteria on a trade transaction.
/// </summary>
[IsoId("_MUTPUZQUEeiok48Eh9lW9Q")]
[DisplayName("Trade Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeQueryCriteria4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeQueryCriteria4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeQueryCriteria4( System.String reqTradeLifeCycleHistory,System.String reqOutstandingTradeIndicator )
    {
        TradeLifeCycleHistory = reqTradeLifeCycleHistory;
        OutstandingTradeIndicator = reqOutstandingTradeIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Field to define whether the query response file will include all reports submitted for a trade [true]or only the current state of the trade [false].
    /// If false is selected, the reporting timestamp field cannot be used.
    /// </summary>
    [IsoId("_MepeI5QUEeiok48Eh9lW9Q")]
    [DisplayName("Trade Life Cycle History")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradLifeCyclHstry")]
    #endif
    [IsoXmlTag("TradLifeCyclHstry")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator TradeLifeCycleHistory { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeLifeCycleHistory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeLifeCycleHistory { get; init; } 
    #else
    public System.String TradeLifeCycleHistory { get; set; } 
    #endif
    
    /// <summary>
    /// Field to define whether if the query response file will include all trades or only the outstanding trades.
    /// </summary>
    [IsoId("_MepeJZQUEeiok48Eh9lW9Q")]
    [DisplayName("Outstanding Trade Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngTradInd")]
    #endif
    [IsoXmlTag("OutsdngTradInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator OutstandingTradeIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OutstandingTradeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OutstandingTradeIndicator { get; init; } 
    #else
    public System.String OutstandingTradeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Query criteria related to counterparties.
    /// </summary>
    [IsoId("_MepeJ5QUEeiok48Eh9lW9Q")]
    [DisplayName("Trade Party Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPtyCrit")]
    #endif
    [IsoXmlTag("TradPtyCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyQueryCriteria3? TradePartyCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyQueryCriteria3? TradePartyCriteria { get; init; } 
    #else
    public TradePartyQueryCriteria3? TradePartyCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the query criteria related to financial instruments.
    /// </summary>
    [IsoId("_MepeKZQUEeiok48Eh9lW9Q")]
    [DisplayName("Financial Instrument Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmCrit")]
    #endif
    [IsoXmlTag("FinInstrmCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeSecurityIdentificationQueryCriteria2? FinancialInstrumentCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeSecurityIdentificationQueryCriteria2? FinancialInstrumentCriteria { get; init; } 
    #else
    public TradeSecurityIdentificationQueryCriteria2? FinancialInstrumentCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Query criteria related to time values.
    /// </summary>
    [IsoId("_MepeK5QUEeiok48Eh9lW9Q")]
    [DisplayName("Time Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCrit")]
    #endif
    [IsoXmlTag("TmCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDateTimeQueryCriteria2? TimeCriteria { get; init; } 
    #else
    public TradeDateTimeQueryCriteria2? TimeCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Query criteria related to other fields.
    /// </summary>
    [IsoId("_MepeLZQUEeiok48Eh9lW9Q")]
    [DisplayName("Other Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCrit")]
    #endif
    [IsoXmlTag("OthrCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeAdditionalQueryCriteria3? OtherCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeAdditionalQueryCriteria3? OtherCriteria { get; init; } 
    #else
    public TradeAdditionalQueryCriteria3? OtherCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}
