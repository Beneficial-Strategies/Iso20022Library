// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of a system and the period of time during which the status is valid.
/// </summary>
[IsoId("_xCzJx5lcEeeE1Ya-LgRsuQ")]
[DisplayName("System Status")]
public partial record SystemStatus3
{
    #nullable enable
    
    /// <summary>
    /// Current status of a system.
    /// </summary>
    [IsoId("_xLYeAZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required SystemStatus2Choice_ Status { get; init; } 
    
    /// <summary>
    /// Period of time during which the status of the system is valid.
    /// </summary>
    [IsoId("_xLYeA5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Validity Time")]
    [IsoXmlTag("VldtyTm")]
    public DateTimePeriod1Choice_? ValidityTime { get; init; } 
    
    
    #nullable disable
    
}
