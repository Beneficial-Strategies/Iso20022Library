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
[IsoId("__Mkz8SYBEeym0KcvJF9aDQ")]
[DisplayName("Point Of Interaction Component")]
public record PointOfInteractionComponent13
{
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("__SG0MSYBEeym0KcvJF9aDQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType5Code Type { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("__SG0MyYBEeym0KcvJF9aDQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification3 Identification { get; init; }

    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("__SG0NSYBEeym0KcvJF9aDQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("__SG0NyYBEeym0KcvJF9aDQ")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public GenericIdentification48? StandardCompliance { get; init; }

    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("__SG0OSYBEeym0KcvJF9aDQ")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics4? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("__SG0OyYBEeym0KcvJF9aDQ")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public PointOfInteractionComponentIdentification3? Assessment { get; init; }
}
