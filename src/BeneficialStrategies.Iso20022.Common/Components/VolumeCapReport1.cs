// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Double volume cap report.
/// </summary>
[IsoId("_AE700CohEeW8U9pZarPocw")]
[DisplayName("Volume Cap Report")]
public partial record VolumeCapReport1
{
    #nullable enable
    
    /// <summary>
    /// Date or date range the report relates to.
    /// </summary>
    [IsoId("_04oOYeJBEeWWKb0jFHxViQ")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public Period4Choice_? ReportingPeriod { get; init; } 
    
    /// <summary>
    /// The venue this report is in relation to specified as {MIC} (segment MIC, where available, otherwise operational MIC).
    /// </summary>
    [IsoId("_Uc9EUORREeW25oRYRCmhTA")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    public IsoMICIdentifier? TradingVenue { get; init; } 
    
    /// <summary>
    /// Volume cap data specific to a reporting period.
    /// </summary>
    [IsoId("_Jl8K8OJCEeWWKb0jFHxViQ")]
    [DisplayName("Instrument Report")]
    [IsoXmlTag("InstrmRpt")]
    public ValueList<VolumeCapReport2> InstrumentReport { get; init; } = new ValueList<VolumeCapReport2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Jl8K8OJCEeWWKb0jFHxViQ
    
    
    #nullable disable
    
}
