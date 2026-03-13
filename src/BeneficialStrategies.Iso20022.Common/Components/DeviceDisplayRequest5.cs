// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the content of the display request message.
/// </summary>
[IsoId("_4tgToXGZEe2TbaNWBpRZpQ")]
[DisplayName("Device Display Request")]
public partial record DeviceDisplayRequest5
{
    #nullable enable
    
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_40P00XGZEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage10> DisplayOutput { get; init; } = [];
    // ID for the above is _40P00XGZEe2TbaNWBpRZpQ
    
    
    #nullable disable
    
}
