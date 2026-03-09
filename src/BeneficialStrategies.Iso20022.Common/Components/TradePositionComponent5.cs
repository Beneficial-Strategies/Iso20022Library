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
/// Provides details of a component report on a trade position.
/// </summary>
[IsoId("_BmwjgQ1LEeqV4s5SpzR1dQ")]
[DisplayName("Trade Position Component")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradePositionComponent5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradePositionComponent5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradePositionComponent5( CommonTradeDataReport38 reqCommonTradeData )
    {
        CommonTradeData = reqCommonTradeData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    [IsoId("_BngxcQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Specific Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySpcfcData")]
    #endif
    [IsoXmlTag("CtrPtySpcfcData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartySpecificData24> CounterpartySpecificData { get; init; } = new ValueList<CounterpartySpecificData24>(){};
    
    /// <summary>
    /// Contract and transaction trade data details.
    /// </summary>
    [IsoId("_Bngxcw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Common Trade Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonTradData")]
    #endif
    [IsoXmlTag("CmonTradData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CommonTradeDataReport38 CommonTradeData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CommonTradeDataReport38 CommonTradeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommonTradeDataReport38 CommonTradeData { get; init; } 
    #else
    public CommonTradeDataReport38 CommonTradeData { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_BngxdQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Technical Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechAttrbts")]
    #endif
    [IsoXmlTag("TechAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    #else
    public TechnicalAttributes1? TechnicalAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Bngxdw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
