// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for identification of a party.
/// </summary>
[IsoId("_wNKtoDFREeGpgKb_ecoJPw")]
[DisplayName("Organisation Identification SD")]
public partial record OrganisationIdentificationSD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_crO00FPIEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Name in the local language by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_hVxlNWzeEeGa9q9Mq4E7uA")]
    [DisplayName("Local Language Name")]
    [IsoXmlTag("LclLangNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    public required IsoMax240Text LocalLanguageName { get; init; } 
    
    
    #nullable disable
    
}
