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
[IsoId("_jbxlEY0SEeWRYffwL7E13A")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent6
{
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_jmMsYY0SEeWRYffwL7E13A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType4Code Type { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jmMsY40SEeWRYffwL7E13A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification1 Identification { get; init; }

    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jmMsZY0SEeWRYffwL7E13A")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_jmMsZ40SEeWRYffwL7E13A")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public ValueList<GenericIdentification48> StandardCompliance { get; init; } = [];

    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jmMsaY0SEeWRYffwL7E13A")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics2? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_jmMsa40SEeWRYffwL7E13A")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<PointOfInteractionComponentAssessment1> Assessment { get; init; } = [];
}
