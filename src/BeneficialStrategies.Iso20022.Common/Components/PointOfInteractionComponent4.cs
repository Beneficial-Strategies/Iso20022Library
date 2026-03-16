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
[IsoId("_4wploS9SEeOlZIh7PImd0A")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent4
{
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_5BKt4S9SEeOlZIh7PImd0A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType3Code Type { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_5BKt4y9SEeOlZIh7PImd0A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification1 Identification { get; init; }

    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_5BKt5S9SEeOlZIh7PImd0A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus1? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_5BKt5y9SEeOlZIh7PImd0A")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public GenericIdentification48? StandardCompliance { get; init; }

    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_5BKt6S9SEeOlZIh7PImd0A")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics2? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_5BKt6y9SEeOlZIh7PImd0A")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public PointOfInteractionComponentAssessment1? Assessment { get; init; }
}
