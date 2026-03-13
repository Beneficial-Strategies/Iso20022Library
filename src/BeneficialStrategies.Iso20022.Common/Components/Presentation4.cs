// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the presentation of documents.
/// </summary>
[IsoId("_vsXgeX1qEeGlwNeVP9egyg")]
[DisplayName("Presentation")]
public partial record Presentation4
{
    #nullable enable
    
    /// <summary>
    /// Medium through which the presentation can be submitted such as paper, electronic or both.
    /// </summary>
    [IsoId("_vsXgfH1qEeGlwNeVP9egyg")]
    [DisplayName("Medium")]
    [IsoXmlTag("Mdm")]
    public PresentationMedium1Choice_? Medium { get; init; } 
    
    /// <summary>
    /// Document required to be presented.
    /// </summary>
    [IsoId("_vsXgh31qEeGlwNeVP9egyg")]
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public Document11? Document { get; init; } 
    
    /// <summary>
    /// Additional information related to the presentation.
    /// </summary>
    [IsoId("_vsXgf31qEeGlwNeVP9egyg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
    
    
    #nullable disable
    
}
