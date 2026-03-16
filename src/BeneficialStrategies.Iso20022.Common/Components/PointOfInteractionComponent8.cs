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
[IsoId("_LdXogdqiEeearpaEPXv9UA")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent8
{
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_LmRs4dqiEeearpaEPXv9UA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType5Code Type { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_LmRs49qiEeearpaEPXv9UA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification1 Identification { get; init; }

    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_LmRs5dqiEeearpaEPXv9UA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_LmRs59qiEeearpaEPXv9UA")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public ValueList<GenericIdentification48> StandardCompliance { get; init; } = [];

    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_LmRs6dqiEeearpaEPXv9UA")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics4? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_LmRs69qiEeearpaEPXv9UA")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<PointOfInteractionComponentAssessment1> Assessment { get; init; } = [];
}
