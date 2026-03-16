// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point Of Interaction Component15.
/// </summary>
[IsoId("_SZOUQZFKEe6reqfAp4CunQ")]
[DisplayName("Point Of Interaction Component15")]
public partial record PointOfInteractionComponent15
{
    #nullable enable

    /// <summary>
    /// Assessment.
    /// </summary>
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public ValueList<PointOfInteractionComponentAssessment1> Assessment { get; init; } = [];

    /// <summary>
    /// Characteristics.
    /// </summary>
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics10? Characteristics { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification2 Identification { get; init; } 

    /// <summary>
    /// Package.
    /// </summary>
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<PackageType5> Package { get; init; } = [];

    /// <summary>
    /// Standard Compliance.
    /// </summary>
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public ValueList<GenericIdentification48> StandardCompliance { get; init; } = [];

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; } 

    /// <summary>
    /// Sub Type Information.
    /// </summary>
    [DisplayName("Sub Type Information")]
    [IsoXmlTag("SubTpInf")]
    public IsoMax70Text? SubTypeInformation { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType6Code Type { get; init; } 

    
    #nullable disable
    
}
