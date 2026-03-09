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
/// Specifies the values used to calculate positions.
/// </summary>
[IsoId("_0w3kQQ1MEeqV4s5SpzR1dQ")]
[DisplayName("Position Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSet5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PositionSet5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PositionSet5( PositionSetDimensions3 reqDimensions,PositionSetMetrics1 reqMetrics )
    {
        Dimensions = reqDimensions;
        Metrics = reqMetrics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Variables related to derivatives that are used to group derivatives together into positions.
    /// </summary>
    [IsoId("_0xmkEQ1MEeqV4s5SpzR1dQ")]
    [DisplayName("Dimensions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dmnsns")]
    #endif
    [IsoXmlTag("Dmnsns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PositionSetDimensions3 Dimensions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PositionSetDimensions3 Dimensions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetDimensions3 Dimensions { get; init; } 
    #else
    public PositionSetDimensions3 Dimensions { get; set; } 
    #endif
    
    /// <summary>
    /// Variables used to quantify the different calculations.
    /// </summary>
    [IsoId("_0xmkEw1MEeqV4s5SpzR1dQ")]
    [DisplayName("Metrics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtrcs")]
    #endif
    [IsoXmlTag("Mtrcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PositionSetMetrics1 Metrics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PositionSetMetrics1 Metrics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionSetMetrics1 Metrics { get; init; } 
    #else
    public PositionSetMetrics1 Metrics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
