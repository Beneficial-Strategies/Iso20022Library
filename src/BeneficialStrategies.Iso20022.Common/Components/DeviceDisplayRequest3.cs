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
[IsoId("_1jAyIS8_Eeu125Ip9zFcsQ")]
[DisplayName("Device Display Request")]
public partial record DeviceDisplayRequest3
{
    #nullable enable
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_1vV98S8_Eeu125Ip9zFcsQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage8> DisplayOutput { get; init; } = [];
    // ID for the above is _1vV98S8_Eeu125Ip9zFcsQ
    
    
    #nullable disable
    
}
