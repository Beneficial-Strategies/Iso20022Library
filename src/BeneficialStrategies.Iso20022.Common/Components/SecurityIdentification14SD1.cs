// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to identify a security by proprietary or domestic identification scheme.
/// </summary>
[IsoId("_0UXo3nJSEeG0c8Yq2arGQg")]
[DisplayName("Security Identification 14 SD")]
public partial record SecurityIdentification14SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_0UXo4XJSEeG0c8Yq2arGQg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Abbreviated name of the underlying securities in the local language.
    /// Note that in case of non-listed securities, it will be a full local language securities name.
    /// 銘柄名（銘柄略称）.
    /// </summary>
    [IsoId("_0UXo5nJSEeG0c8Yq2arGQg")]
    [DisplayName("Abbreviated Local Language Security Name")]
    [IsoXmlTag("AbbrvtdLclLangSctyNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    public required IsoMax240Text AbbreviatedLocalLanguageSecurityName { get; init; } 
    
    
    #nullable disable
    
}
