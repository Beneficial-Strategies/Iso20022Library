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
[IsoId("_mhI4IAySEeK5P9Ihqok3VA")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent3
{
    /// <summary>
    /// Type of component belonging to a POI Terminal.
    /// </summary>
    [IsoId("_1uTl4AySEeK5P9Ihqok3VA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType3Code Type { get; init; }

    /// <summary>
    /// Identification of the POI component.
    /// </summary>
    [IsoId("_EZQXYAyTEeK5P9Ihqok3VA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification1 Identification { get; init; }

    /// <summary>
    /// Status of the POI component.
    /// </summary>
    [IsoId("_YFaY8AyTEeK5P9Ihqok3VA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus1? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_r4fh4AyTEeK5P9Ihqok3VA")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public ValueList<GenericIdentification48> StandardCompliance { get; init; } = [];

    /// <summary>
    /// Characteristics of a POI component.
    /// </summary>
    [IsoId("_4DJg4AyTEeK5P9Ihqok3VA")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics1? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_QtXX4AyUEeK5P9Ihqok3VA")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<PointOfInteractionComponentAssessment1> Assessment { get; init; } = [];
}
