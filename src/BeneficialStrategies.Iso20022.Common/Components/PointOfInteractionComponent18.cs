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
[IsoId("_jlw1YbZyEfCUZfsQO4rYeA")]
[DisplayName("Point Of Interaction Component18")]
public record PointOfInteractionComponent18
{
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_jmq0VbZyEfCUZfsQO4rYeA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType7Code Type { get; init; }

    /// <summary>
    /// Additional information regarding the type of the component.
    /// </summary>
    [IsoId("_jmq0W7ZyEfCUZfsQO4rYeA")]
    [DisplayName("Sub Type Information")]
    [IsoXmlTag("SubTpInf")]
    public IsoMax70Text? SubTypeInformation { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jmq0YbZyEfCUZfsQO4rYeA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification2 Identification { get; init; }

    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jmq0Z7ZyEfCUZfsQO4rYeA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; }

    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_jmq0bbZyEfCUZfsQO4rYeA")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public ValueList<GenericIdentification48> StandardCompliance { get; init; } = [];

    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_jmq0c7ZyEfCUZfsQO4rYeA")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics11? Characteristics { get; init; }

    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_jmq0ebZyEfCUZfsQO4rYeA")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<PointOfInteractionComponentAssessment1> Assessment { get; init; } = [];

    /// <summary>
    /// Chunk of a software package.
    /// </summary>
    [IsoId("_jmq0f7ZyEfCUZfsQO4rYeA")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType5> Package { get; init; } = [];

    /// <summary>
    /// Provides the value recorded by this probe.
    /// </summary>
    [IsoId("_jmq0hbZyEfCUZfsQO4rYeA")]
    [DisplayName("Probe Value")]
    [IsoXmlTag("PrbVal")]
    public IsoMax35Binary? ProbeValue { get; init; }
}
