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
/// Numeric variables calculated on the number of transactions or on market exposures.
/// </summary>
[IsoId("_HPOrga5QEeuo-IflVgGqiA")]
[DisplayName("Volume Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VolumeMetrics6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Aggregations of all positive values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_Hd-5Ma5QEeuo-IflVgGqiA")]
    [DisplayName("Positive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Postv")]
    #endif
    [IsoXmlTag("Postv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureMetrics5? Positive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureMetrics5? Positive { get; init; } 
    #else
    public ExposureMetrics5? Positive { get; set; } 
    #endif
    
    /// <summary>
    /// Aggregations of all negative values of the derivative for all derivatives pertaining to a position set.
    /// </summary>
    [IsoId("_Hd-5M65QEeuo-IflVgGqiA")]
    [DisplayName("Negative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Neg")]
    #endif
    [IsoXmlTag("Neg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExposureMetrics5? Negative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureMetrics5? Negative { get; init; } 
    #else
    public ExposureMetrics5? Negative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
