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
/// Defines a frequency in terms a specific moment within a specified period type.
/// </summary>
[IsoId("_CWY182k3Eeanu6HLe77Rkg")]
[DisplayName("Frequency And Moment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FrequencyAndMoment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FrequencyAndMoment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FrequencyAndMoment1( Frequency6Code reqType,System.String reqPointInTime )
    {
        Type = reqType;
        PointInTime = reqPointInTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Period for which the number of instructions are to be created and processed.
    /// </summary>
    [IsoId("_CWY19Wk3Eeanu6HLe77Rkg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Frequency6Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Frequency6Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency6Code Type { get; init; } 
    #else
    public Frequency6Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Further information on the exact point in time the event should take place.
    /// </summary>
    [IsoId("_CWY19Gk3Eeanu6HLe77Rkg")]
    [DisplayName("Point In Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtInTm")]
    #endif
    [IsoXmlTag("PtInTm")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact2NumericText PointInTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PointInTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PointInTime { get; init; } 
    #else
    public System.String PointInTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
