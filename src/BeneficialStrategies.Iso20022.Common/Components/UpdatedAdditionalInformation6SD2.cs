// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to provide the local language information of the new company name when the corporate action event type code is CHAN (name change).
/// </summary>
[IsoId("_5TGglnI6EeG0c8Yq2arGQg")]
[DisplayName("Updated Additional Information 6 SD")]
public partial record UpdatedAdditionalInformation6SD2
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_4qogd3I8EeG0c8Yq2arGQg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Full and formal name of underlying securities in the local language.
    /// </summary>
    [IsoId("_MYnuCHI9EeG0c8Yq2arGQg")]
    [DisplayName("Full Local Language Security Name")]
    [IsoXmlTag("FullLclLangSctyNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    public IsoMax240Text? FullLocalLanguageSecurityName { get; init; } 
    
    /// <summary>
    /// Abbreviated name of underlying securities in the local language. 
    /// In case of non-listed securities, it will be a full local language security name.
    /// 銘柄名（銘柄略称.
    /// </summary>
    [IsoId("_MYnuDXI9EeG0c8Yq2arGQg")]
    [DisplayName("Abbreviated Local Language Security Name")]
    [IsoXmlTag("AbbrvtdLclLangSctyNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    public required IsoMax240Text AbbreviatedLocalLanguageSecurityName { get; init; } 
    
    
    #nullable disable
    
}
