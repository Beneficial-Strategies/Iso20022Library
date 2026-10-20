// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point Of Interaction Component16.
/// </summary>
[IsoId("_Gr4uYW6jEe6DxcrvCrq6hQ")]
[DisplayName("Point Of Interaction Component16")]
public partial record PointOfInteractionComponent16
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType5Code Type { get; init; }

    /// <summary>
    /// Item Number.
    /// </summary>
    [DisplayName("Item Number")]
    [IsoXmlTag("ItmNb")]
    public Max35Text? ItemNumber { get; init; }

    /// <summary>
    /// Provider Identification.
    /// </summary>
    [DisplayName("Provider Identification")]
    [IsoXmlTag("PrvdrId")]
    public Max35Text? ProviderIdentification { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Max35Text? Identification { get; init; }

    /// <summary>
    /// Serial Number.
    /// </summary>
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    public Max70Text? SerialNumber { get; init; }
}
