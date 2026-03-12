// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for business information.
/// </summary>
[IsoId("_51l8cZlZEeeE1Ya-LgRsuQ")]
[DisplayName("General Business Information Search Criteria")]
public partial record GeneralBusinessInformationSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous reference assigned to a general business information system.
    /// </summary>
    [IsoId("_59y2MZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; } 
    
    /// <summary>
    /// Subject line of an item of general business information, summarizing the topic and intended destination of the information.
    /// </summary>
    [IsoId("_59y2M5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Subject")]
    [IsoXmlTag("Sbjt")]
    public CharacterSearch1Choice_? Subject { get; init; } 
    
    /// <summary>
    /// Further information about the criticality or importance of a general business information system.
    /// </summary>
    [IsoId("_59y2NZlZEeeE1Ya-LgRsuQ")]
    [DisplayName("Qualifier")]
    [IsoXmlTag("Qlfr")]
    public InformationQualifierType1? Qualifier { get; init; } 
    
    
    #nullable disable
    
}
