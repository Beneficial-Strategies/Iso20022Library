// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains text fields in the local language.
/// </summary>
[IsoId("_TPWQUcW7EeuhguwJmlgagQ")]
[DisplayName("Local Data")]
public partial record LocalData4
{
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_TT8cccW7EeuhguwJmlgagQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public required ISOMax3ALanguageCode Language { get; init; } 
    
    /// <summary>
    /// Short name of the party in the local language.
    /// </summary>
    [IsoId("_TT8cc8W7EeuhguwJmlgagQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ShortName { get; init; } 
    
    /// <summary>
    /// Legal Corporate Name of the party in the local language
    /// </summary>
    [IsoId("_Dq42wCB6Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? LegalCorporateName { get; init; } 
    
    /// <summary>
    /// Name and location of acceptor in the local language.  May only contain name when the location is specified elsewhere.
    /// </summary>
    [IsoId("_aT8UesW7EeuhguwJmlgagQ")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max200Text)]
    [StringLength(maximumLength: 200 ,MinimumLength = 1)]
    public IsoMax200Text? NameAndLocation { get; init; } 
    
    /// <summary>
    /// Structured postal address in the local language.
    /// </summary>
    [IsoId("_jofpAcW7EeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address3? Address { get; init; } 
    
    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_75FwdMosEeuuJ571wNLKkA")]
    [DisplayName("Additional Address Information")]
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max512Text)]
    [StringLength(maximumLength: 512 ,MinimumLength = 1)]
    public IsoMax512Text? AdditionalAddressInformation { get; init; } 
    
    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// </summary>
    [IsoId("_fKYT0cotEeuuJ571wNLKkA")]
    [DisplayName("Additional Contact Information")]
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max512Text)]
    [StringLength(maximumLength: 512 ,MinimumLength = 1)]
    public IsoMax512Text? AdditionalContactInformation { get; init; } 
    
    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_tZ10AcXLEeumGdYElfgmbw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
