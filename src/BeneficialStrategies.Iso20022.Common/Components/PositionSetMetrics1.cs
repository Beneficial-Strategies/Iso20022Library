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
/// Variables used to quantify the different calculations for position sets and currency position sets reports.
/// </summary>
[IsoId("_t0oSlcWEEeiRga8tPu1L4Q")]
[DisplayName("Position Set Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetMetrics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Refers to the total number of trades contained in the position set.
    /// </summary>
    [IsoId("_t0oSoMWEEeiRga8tPu1L4Q")]
    [DisplayName("Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ttl")]
    #endif
    [IsoXmlTag("Ttl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetBuyerAndSeller1? Total { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetBuyerAndSeller1? Total { get; init; } 
    #else
    public PositionSetBuyerAndSeller1? Total { get; set; } 
    #endif
    
    /// <summary>
    /// Refers to the aggregated number of trades contained in the position set.
    /// </summary>
    [IsoId("_t0oSo8WEEeiRga8tPu1L4Q")]
    [DisplayName("Clean")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clean")]
    #endif
    [IsoXmlTag("Clean")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionSetBuyerAndSeller1? Clean { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetBuyerAndSeller1? Clean { get; init; } 
    #else
    public PositionSetBuyerAndSeller1? Clean { get; set; } 
    #endif
    
    
    #nullable disable
    
}
