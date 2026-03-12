// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Display Request message.
/// </summary>
[IsoId("_EtpAQQ0cEeqUVL7sB4m7NA")]
[DisplayName("Device Display Request")]
public partial record DeviceDisplayRequest2
{
    #nullable enable
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_E5GpYQ0cEeqUVL7sB4m7NA")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage7> DisplayOutput { get; init; } = new ValueList<ActionMessage7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _E5GpYQ0cEeqUVL7sB4m7NA
    
    
    #nullable disable
    
}
