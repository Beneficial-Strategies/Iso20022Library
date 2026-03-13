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
[IsoId("_sG-JsN6lEeiwsev40qZGEQ")]
[DisplayName("Device Display Request")]
public partial record DeviceDisplayRequest1
{
    #nullable enable
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_1UuSsN6lEeiwsev40qZGEQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage6> DisplayOutput { get; init; } = [];
    // ID for the above is _1UuSsN6lEeiwsev40qZGEQ
    
    
    #nullable disable
    
}
