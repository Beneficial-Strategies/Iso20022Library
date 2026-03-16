// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the content of the display request message.
/// </summary>
[IsoId("_4tgToXGZEe2TbaNWBpRZpQ")]
[DisplayName("Device Display Request")]
public record DeviceDisplayRequest5
{
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    [IsoId("_40P00XGZEe2TbaNWBpRZpQ")]
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ValueList<ActionMessage10> DisplayOutput { get; init; } = [];
    // ID for the above is _40P00XGZEe2TbaNWBpRZpQ
}
