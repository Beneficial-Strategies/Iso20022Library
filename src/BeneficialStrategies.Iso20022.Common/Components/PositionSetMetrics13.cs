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
[IsoId("_jYQGYc-nEeufOvGsyZiDWA")]
[DisplayName("Position Set Metrics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetMetrics13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PositionSetMetrics13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PositionSetMetrics13( VolumeMetrics5 reqVolumeMetrics )
    {
        VolumeMetrics = reqVolumeMetrics;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Numeric variables calculated on the number of transactions or on market exposures.
    /// </summary>
    [IsoId("_jbN60c-nEeufOvGsyZiDWA")]
    [DisplayName("Volume Metrics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VolMtrcs")]
    #endif
    [IsoXmlTag("VolMtrcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VolumeMetrics5 VolumeMetrics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VolumeMetrics5 VolumeMetrics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VolumeMetrics5 VolumeMetrics { get; init; } 
    #else
    public VolumeMetrics5 VolumeMetrics { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric variables consisting in interest rates, lending fees or haircuts, calculated as weighted averages.
    /// </summary>
    [IsoId("_jbN608-nEeufOvGsyZiDWA")]
    [DisplayName("Price Metrics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricMtrcs")]
    #endif
    [IsoXmlTag("PricMtrcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceMetrics3? PriceMetrics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceMetrics3? PriceMetrics { get; init; } 
    #else
    public PriceMetrics3? PriceMetrics { get; set; } 
    #endif
    
    
    #nullable disable
    
}
