// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point Of Interaction Component16.
/// </summary>
[IsoId("_Gr4uYW6jEe6DxcrvCrq6hQ")]
[DisplayName("Point Of Interaction Component16")]
public partial record PointOfInteractionComponent16
{
    #nullable enable

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; } 

    /// <summary>
    /// Item Number.
    /// </summary>
    [DisplayName("Item Number")]
    [IsoXmlTag("ItmNb")]
    public IsoMax35Text? ItemNumber { get; init; } 

    /// <summary>
    /// Provider Identification.
    /// </summary>
    [DisplayName("Provider Identification")]
    [IsoXmlTag("PrvdrId")]
    public IsoMax35Text? ProviderIdentification { get; init; } 

    /// <summary>
    /// Serial Number.
    /// </summary>
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    public IsoMax70Text? SerialNumber { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType5Code Type { get; init; } 

    
    #nullable disable
    
}
