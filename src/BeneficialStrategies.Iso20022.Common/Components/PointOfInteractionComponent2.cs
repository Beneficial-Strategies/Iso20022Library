// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a component of the POI.
/// </summary>
[IsoId("_LYLC4H1DEeCF8NjrBemJWQ_1913950683")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent2
{
    /// <summary>
    /// Type of component belonging to a POI Terminal.
    /// </summary>
    [IsoId("_LYLC4X1DEeCF8NjrBemJWQ_1800111617")]
    [DisplayName("POI Component Type")]
    [IsoXmlTag("POICmpntTp")]
    public required POIComponentType2Code POIComponentType { get; init; }

    /// <summary>
    /// Identification of the software, hardware or system provider of the POI component.
    /// </summary>
    [IsoId("_LYUz4H1DEeCF8NjrBemJWQ_803039264")]
    [DisplayName("Manufacturer Identification")]
    [IsoXmlTag("ManfctrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ManufacturerIdentification { get; init; }

    /// <summary>
    /// Identification of a model of POI component for a given manufacturer.
    /// </summary>
    [IsoId("_LYUz4X1DEeCF8NjrBemJWQ_-194033089")]
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Model { get; init; }

    /// <summary>
    /// Version of component belonging to a given model.
    /// </summary>
    [IsoId("_LYUz4n1DEeCF8NjrBemJWQ_-1191105442")]
    [DisplayName("Version Number")]
    [IsoXmlTag("VrsnNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? VersionNumber { get; init; }

    /// <summary>
    /// Serial number of a component.
    /// </summary>
    [IsoId("_LYUz431DEeCF8NjrBemJWQ_2106789501")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SerialNumber { get; init; }

    /// <summary>
    /// Unique approval number for a component, delivered by a certification body.
    /// Usage: More than one approval number could be present, when assigned by different bodies. The certification body identification must be provided within the approval number (for example at the beginning of the value).
    /// </summary>
    [IsoId("_LYUz5H1DEeCF8NjrBemJWQ_1109717148")]
    [DisplayName("Approval Number")]
    [IsoXmlTag("ApprvlNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ApprovalNumber { get; init; }
}
