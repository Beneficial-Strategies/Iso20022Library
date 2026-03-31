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
[IsoId("_jNiLIXDVEe2MCaKO5AtGsA")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent14
{
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_jUkAMXDVEe2MCaKO5AtGsA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType6Code Type { get; init; }

    /// <summary>
    /// Additional information regarding the type of the component.
    /// </summary>
    [IsoId("_jUknQXDVEe2MCaKO5AtGsA")]
    [DisplayName("Sub Type Information")]
    [IsoXmlTag("SubTpInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SubTypeInformation { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jUknQ3DVEe2MCaKO5AtGsA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification2 Identification { get; init; }

    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jUknRXDVEe2MCaKO5AtGsA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_jUknR3DVEe2MCaKO5AtGsA")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public ValueList<GenericIdentification48> StandardCompliance { get; init; } = [];

    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jUknSXDVEe2MCaKO5AtGsA")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics9? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_jUknS3DVEe2MCaKO5AtGsA")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<PointOfInteractionComponentAssessment1> Assessment { get; init; } = [];

    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_jUknTXDVEe2MCaKO5AtGsA")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType4> Package { get; init; } = [];
}
