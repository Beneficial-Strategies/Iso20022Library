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
[IsoId("_q_KfcSYBEeym0KcvJF9aDQ")]
[DisplayName("Point Of Interaction Component Identification")]
public record PointOfInteractionComponentIdentification3
{
    /// <summary>
    /// Hierarchical identification of a hardware component inside all the hardware component of the POI. It is composed of all item numbers of the upper level components, separated by the &apos;.&apos; character, ended by the item number of the current component.
    /// </summary>
    [IsoId("_rEN-kSYBEeym0KcvJF9aDQ")]
    [DisplayName("Item Number")]
    [IsoXmlTag("ItmNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ItemNumber { get; init; }

    /// <summary>
    /// Identifies the provider of the software, hardware or parameters of the POI component.
    /// </summary>
    [IsoId("_rEN-kyYBEeym0KcvJF9aDQ")]
    [DisplayName("Provider Identification")]
    [IsoXmlTag("PrvdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProviderIdentification { get; init; }

    /// <summary>
    /// Identification of the POI component assigned by its provider.
    /// </summary>
    [IsoId("_rEN-lSYBEeym0KcvJF9aDQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Serial number identifying an occurrence of an hardware component.
    /// </summary>
    [IsoId("_rEN-lyYBEeym0KcvJF9aDQ")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SerialNumber { get; init; }
}
