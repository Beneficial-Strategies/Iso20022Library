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
/// Variables used to quantify the different calculations for position sets.
/// </summary>
[IsoId("_zRofMa5QEeuo-IflVgGqiA")]
[DisplayName("Position Set Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetMetrics10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Numeric variables calculated on the number of transactions or on market exposures.
    /// </summary>
    [IsoId("_zg_J0a5QEeuo-IflVgGqiA")]
    [DisplayName("Volume Metrics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VolMtrcs")]
    #endif
    [IsoXmlTag("VolMtrcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureMetrics6? VolumeMetrics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureMetrics6? VolumeMetrics { get; init; } 
    #else
    public ExposureMetrics6? VolumeMetrics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
