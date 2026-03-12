// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the volume and value percentage rates of internalised settlement instructions.
/// </summary>
[IsoId("_3T-LI-3tEeaWjpoyrnG6Rw")]
[DisplayName("Internalisation Data Rate")]
public partial record InternalisationDataRate1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the rate, in terms of volume, of the failed internalised settlement instructions compared to the total volume, of internalised settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_3T-LJe3tEeaWjpoyrnG6Rw")]
    [DisplayName("Volume Percentage")]
    [IsoXmlTag("VolPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate VolumePercentage { get; init; } 
    
    /// <summary>
    /// Specifies the rate, in terms of value, of the failed internalised settlement instructions compared to the total value of internalised settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_3T-LJO3tEeaWjpoyrnG6Rw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Value { get; init; } 
    
    
    #nullable disable
    
}
