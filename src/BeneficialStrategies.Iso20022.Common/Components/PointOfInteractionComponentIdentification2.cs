// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a POI (Point of Interaction) component.
/// </summary>
[IsoId("_fu8XwS8REeu125Ip9zFcsQ")]
[DisplayName("Point Of Interaction Component Identification")]
public record PointOfInteractionComponentIdentification2
{
    /// <summary>
    /// Hierarchical identification of a hardware component inside all the hardware component of the POI. It is composed of all item numbers of the upper level components, separated by the &apos;.&apos; character, ended by the item number of the current component.
    /// </summary>
    [IsoId("_f6KwUS8REeu125Ip9zFcsQ")]
    [DisplayName("Item Number")]
    [IsoXmlTag("ItmNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ItemNumber { get; init; }

    /// <summary>
    /// Identifies the provider of the software, hardware or parameters of the POI component.
    /// </summary>
    [IsoId("_f6KwUy8REeu125Ip9zFcsQ")]
    [DisplayName("Provider Identification")]
    [IsoXmlTag("PrvdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProviderIdentification { get; init; }

    /// <summary>
    /// Identification of the POI component assigned by its provider.
    /// </summary>
    [IsoId("_f6KwVS8REeu125Ip9zFcsQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? Identification { get; init; }

    /// <summary>
    /// Serial number identifying an occurrence of an hardware component.
    /// </summary>
    [IsoId("_f6KwVy8REeu125Ip9zFcsQ")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? SerialNumber { get; init; }
}
