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
/// Double volume cap report.
/// </summary>
[IsoId("_AE700CohEeW8U9pZarPocw")]
[DisplayName("Volume Cap Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VolumeCapReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    [IsoId("_04oOYeJBEeWWKb0jFHxViQ")]
    [DisplayName("Reporting Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgPrd")]
    #endif
    [IsoXmlTag("RptgPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? ReportingPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? ReportingPeriod { get; init; } 
    #else
    public Period4Choice_? ReportingPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// The venue this report is in relation to specified as {MIC} (segment MIC, where available, otherwise operational MIC).
    /// </summary>
    [IsoId("_Uc9EUORREeW25oRYRCmhTA")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradingVenue { get; init; } 
    #else
    public System.String? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Volume cap data specific to a reporting period.
    /// </summary>
    [IsoId("_Jl8K8OJCEeWWKb0jFHxViQ")]
    [DisplayName("Instrument Report")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmRpt")]
    #endif
    [IsoXmlTag("InstrmRpt")]
    public ValueList<VolumeCapReport2> InstrumentReport { get; init; } = new ValueList<VolumeCapReport2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Jl8K8OJCEeWWKb0jFHxViQ
    
    
    #nullable disable
    
}
