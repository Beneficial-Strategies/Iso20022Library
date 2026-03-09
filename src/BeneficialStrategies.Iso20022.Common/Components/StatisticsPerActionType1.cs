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
/// Detailed statistics for submitted derivatives per action type.
/// </summary>
[IsoId("_GQMZcIAsEeirUu_C8Wn_0Q")]
[DisplayName("Statistics Per Action Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatisticsPerActionType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatisticsPerActionType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatisticsPerActionType1( System.UInt64 reqAll,System.UInt64 reqNew,System.UInt64 reqModification )
    {
        All = reqAll;
        New = reqNew;
        Modification = reqModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of derivatives which have been reported.
    /// </summary>
    [IsoId("_PBU34IAsEeirUu_C8Wn_0Q")]
    [DisplayName("All")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="All")]
    #endif
    [IsoXmlTag("All")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber All { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 All { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 All { get; init; } 
    #else
    public System.UInt64 All { get; set; } 
    #endif
    
    /// <summary>
    /// Number of derivatives which have been reported as new.
    /// </summary>
    [IsoId("_QMXusIAsEeirUu_C8Wn_0Q")]
    [DisplayName("New")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="New")]
    #endif
    [IsoXmlTag("New")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber New { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 New { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 New { get; init; } 
    #else
    public System.UInt64 New { get; set; } 
    #endif
    
    /// <summary>
    /// Number of derivatives which have been reported as modified.
    /// </summary>
    [IsoId("_Rh5-QIAsEeirUu_C8Wn_0Q")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20PositiveNumber Modification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Modification { get; init; } 
    #else
    public System.UInt64 Modification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
