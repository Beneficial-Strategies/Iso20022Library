// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a component of the POI performing the transaction.
/// </summary>
[IsoId("_TF_lcAEcEeCQm6a_G2yO_w_1888102349")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent1
{
    /// <summary>
    /// Type of component belonging to a POI Terminal.
    /// </summary>
    [IsoId("_TGJWYAEcEeCQm6a_G2yO_w_1976021057")]
    [DisplayName("POI Component Type")]
    [IsoXmlTag("POICmpntTp")]
    public required POIComponentType1Code POIComponentType { get; init; }

    /// <summary>
    /// Identification of the software, hardware or system provider of the POI component.
    /// </summary>
    [IsoId("_TGJWYQEcEeCQm6a_G2yO_w_-1584000009")]
    [DisplayName("Manufacturer Identification")]
    [IsoXmlTag("ManfctrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ManufacturerIdentification { get; init; }

    /// <summary>
    /// Identification of a model of POI component for a given manufacturer.
    /// </summary>
    [IsoId("_TGJWYgEcEeCQm6a_G2yO_w_409052691")]
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Model { get; init; }

    /// <summary>
    /// Version of component belonging to a given model.
    /// </summary>
    [IsoId("_TGJWYwEcEeCQm6a_G2yO_w_702199434")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? VersionNumber { get; init; }

    /// <summary>
    /// Serial number of a component.
    /// </summary>
    [IsoId("_TGJWZAEcEeCQm6a_G2yO_w_-1015799686")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Unique approval number for a component, delivered by a certification body.
    /// Usage: More than one approval number could be present, when assigned by different bodies. The certification body identification must be provided within the approval number (for example at the beginning of the value).
    /// </summary>
    [IsoId("_TGJWZQEcEeCQm6a_G2yO_w_1420031608")]
    [DisplayName("Approval Number")]
    [IsoXmlTag("ApprvlNb")]
    public SimpleValueList<IsoMax70Text> ApprovalNumber { get; init; } = [];
}
