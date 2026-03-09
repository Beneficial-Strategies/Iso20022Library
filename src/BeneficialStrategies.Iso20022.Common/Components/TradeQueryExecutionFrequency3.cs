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
/// Specifies the frequency of the trade query execution.
/// </summary>
[IsoId("_et5Wt91dEeqxpKDfBZC1vg")]
[DisplayName("Trade Query Execution Frequency")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeQueryExecutionFrequency3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeQueryExecutionFrequency3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeQueryExecutionFrequency3( Frequency14Code reqFrequencyType )
    {
        FrequencyType = reqFrequencyType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the frequency type of the trade query execution.
    /// </summary>
    [IsoId("_evMXN91dEeqxpKDfBZC1vg")]
    [DisplayName("Frequency Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrqcyTp")]
    #endif
    [IsoXmlTag("FrqcyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency14Code FrequencyType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency14Code FrequencyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency14Code FrequencyType { get; init; } 
    #else
    public Frequency14Code FrequencyType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the day of the expected delivery of the query response.
    /// </summary>
    [IsoId("_evMXOd1dEeqxpKDfBZC1vg")]
    [DisplayName("Delivery Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDay")]
    #endif
    [IsoXmlTag("DlvryDay")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public WeekDay3Code? DeliveryDay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WeekDay3Code? DeliveryDay { get; init; } 
    #else
    public WeekDay3Code? DeliveryDay { get; set; } 
    #endif
    
    /// <summary>
    /// Day of the month of the monthly query execution.
    /// </summary>
    [IsoId("_evMXO91dEeqxpKDfBZC1vg")]
    [DisplayName("Day Of Month")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayOfMnth")]
    #endif
    [IsoXmlTag("DayOfMnth")]
    [IsoSimpleType(IsoSimpleType.DayOfMonthNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDayOfMonthNumber? DayOfMonth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DayOfMonth { get; init; } 
    #else
    public System.UInt64? DayOfMonth { get; set; } 
    #endif
    
    
    #nullable disable
    
}
