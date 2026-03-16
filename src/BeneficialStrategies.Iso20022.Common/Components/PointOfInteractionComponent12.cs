// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a component of the POI (Point Of Interaction) performing the transaction.
/// </summary>
[IsoId("_tAsCoVFAEeyApZmLzm74zA")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent12
{
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_tHIo4VFAEeyApZmLzm74zA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType6Code Type { get; init; }

    /// <summary>
    /// Additional information regarding the type of the component.
    /// </summary>
    [IsoId("_tHIo41FAEeyApZmLzm74zA")]
    [DisplayName("Sub Type Information")]
    [IsoXmlTag("SubTpInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SubTypeInformation { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_tHIo5VFAEeyApZmLzm74zA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification2 Identification { get; init; }

    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_tHIo51FAEeyApZmLzm74zA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_tHIo6VFAEeyApZmLzm74zA")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public GenericIdentification48? StandardCompliance { get; init; }

    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_tHIo61FAEeyApZmLzm74zA")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics8? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_tHIo7VFAEeyApZmLzm74zA")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public PointOfInteractionComponentAssessment1? Assessment { get; init; }

    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_tHIo71FAEeyApZmLzm74zA")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public PackageType3? Package { get; init; }
}
