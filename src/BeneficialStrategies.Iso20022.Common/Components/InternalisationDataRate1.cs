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
/// Specifies the volume and value percentage rates of internalised settlement instructions.
/// </summary>
[IsoId("_3T-LI-3tEeaWjpoyrnG6Rw")]
[DisplayName("Internalisation Data Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InternalisationDataRate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InternalisationDataRate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InternalisationDataRate1( System.Decimal reqVolumePercentage,System.Decimal reqValue )
    {
        VolumePercentage = reqVolumePercentage;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the rate, in terms of volume, of the failed internalised settlement instructions compared to the total volume, of internalised settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_3T-LJe3tEeaWjpoyrnG6Rw")]
    [DisplayName("Volume Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VolPctg")]
    #endif
    [IsoXmlTag("VolPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate VolumePercentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal VolumePercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal VolumePercentage { get; init; } 
    #else
    public System.Decimal VolumePercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the rate, in terms of value, of the failed internalised settlement instructions compared to the total value of internalised settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_3T-LJO3tEeaWjpoyrnG6Rw")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Value { get; init; } 
    #else
    public System.Decimal Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}
