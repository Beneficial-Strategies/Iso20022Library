// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured postal address in the local language.
/// </summary>
[IsoId("_sB268cWrEeuhguwJmlgagQ")]
[DisplayName("Address")]
public partial record Address3
{
    #nullable enable
    
    /// <summary>
    /// First line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_sGjNscWrEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine1")]
    [IsoSimpleType(IsoSimpleType.Max200Text)]
    [StringLength(maximumLength: 200 ,MinimumLength = 1)]
    public IsoMax200Text? AddressLine1 { get; init; } 
    
    /// <summary>
    /// Second line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_sGjNs8WrEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine2")]
    [IsoSimpleType(IsoSimpleType.Max200Text)]
    [StringLength(maximumLength: 200 ,MinimumLength = 1)]
    public IsoMax200Text? AddressLine2 { get; init; } 
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_sGjNtcWrEeuhguwJmlgagQ")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max200Text)]
    [StringLength(maximumLength: 200 ,MinimumLength = 1)]
    public IsoMax200Text? StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_sGjNt8WrEeuhguwJmlgagQ")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BuildingNumber { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_sGjNucWrEeuhguwJmlgagQ")]
    [DisplayName("Postal Code")]
    [IsoXmlTag("PstlCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PostalCode { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_sGjNu8WrEeuhguwJmlgagQ")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100Text? TownName { get; init; } 
    
    /// <summary>
    /// Name of the country sub division minor.
    /// </summary>
    [IsoId("_ztabkB1GEey8XKHwKquEQw")]
    [DisplayName("Country Sub Division Minor Name")]
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100Text? CountrySubDivisionMinorName { get; init; } 
    
    /// <summary>
    /// Name of the country sub division major.
    /// </summary>
    [IsoId("_6C5W8B1GEey8XKHwKquEQw")]
    [DisplayName("Country Sub Division Major Name")]
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    public IsoMax100Text? CountrySubDivisionMajorName { get; init; } 
    
    /// <summary>
    /// Nation with its own government occupying a particular territory.
    /// In accordance with ISO 3166-1.
    /// </summary>
    [IsoId("_sGjNwcWrEeuhguwJmlgagQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
