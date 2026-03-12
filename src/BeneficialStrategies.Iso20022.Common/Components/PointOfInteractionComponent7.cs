// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to a component of the POI (Point Of Interaction) performing the transaction.
/// </summary>
[IsoId("_oCGYobCZEeapjPTKZHuM2w")]
[DisplayName("Point Of Interaction Component")]
public partial record PointOfInteractionComponent7
{
    #nullable enable
    
    /// <summary>
    /// Type of component belonging to a POI (Point Of Interaction) Terminal.
    /// </summary>
    [IsoId("_oOnKobCZEeapjPTKZHuM2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required POIComponentType4Code Type { get; init; } 
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_oOnKo7CZEeapjPTKZHuM2w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PointOfInteractionComponentIdentification1 Identification { get; init; } 
    
    /// <summary>
    /// Status of the POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_oOnKpbCZEeapjPTKZHuM2w")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public PointOfInteractionComponentStatus3? Status { get; init; } 
    
    /// <summary>
    /// Identification of the standard for which the component complies with.
    /// </summary>
    [IsoId("_oOnKp7CZEeapjPTKZHuM2w")]
    [DisplayName("Standard Compliance")]
    [IsoXmlTag("StdCmplc")]
    public GenericIdentification48? StandardCompliance { get; init; } 
    
    /// <summary>
    /// Characteristics of a POI (Point Of Interaction) component.
    /// </summary>
    [IsoId("_oOnKqbCZEeapjPTKZHuM2w")]
    [DisplayName("Characteristics")]
    [IsoXmlTag("Chrtcs")]
    public PointOfInteractionComponentCharacteristics3? Characteristics { get; init; } 
    
    /// <summary>
    /// Assessments for the component of the point of interaction.
    /// </summary>
    [IsoId("_oOnKq7CZEeapjPTKZHuM2w")]
    [DisplayName("Assessment")]
    [IsoXmlTag("Assmnt")]
    public PointOfInteractionComponentAssessment1? Assessment { get; init; } 
    
    
    #nullable disable
    
}
