// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured postal address.
/// </summary>
[IsoId("_WZgu8cWqEeuhguwJmlgagQ")]
[DisplayName("Address")]
public partial record Address2
{
    #nullable enable
    
    /// <summary>
    /// First line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_Wd6t0cWqEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine1")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public IsoMax99Text? AddressLine1 { get; init; } 
    
    /// <summary>
    /// Second line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_Wd6t08WqEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine2")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public IsoMax99Text? AddressLine2 { get; init; } 
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_Wd6t1cWqEeuhguwJmlgagQ")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    public IsoMax99Text? StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_Wd6t18WqEeuhguwJmlgagQ")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_Wd6t2cWqEeuhguwJmlgagQ")]
    [DisplayName("Postal Code")]
    [IsoXmlTag("PstlCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? PostalCode { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_Wd6t28WqEeuhguwJmlgagQ")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? TownName { get; init; } 
    
    /// <summary>
    /// Identifies a minor subdivision of a country, for instance county, prefecture.
    /// In accordance with ISO 3166-2 or the local authority.
    /// </summary>
    [IsoId("_Wd6t3cWqEeuhguwJmlgagQ")]
    [DisplayName("Country Sub Division Minor")]
    [IsoXmlTag("CtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? CountrySubDivisionMinor { get; init; } 
    
    /// <summary>
    /// Identifies a major subdivision of a country, for instance state, province.
    /// In accordance with ISO 3166-2 or the local authority.
    /// </summary>
    [IsoId("_Wd6t38WqEeuhguwJmlgagQ")]
    [DisplayName("Country Sub Division Major")]
    [IsoXmlTag("CtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? CountrySubDivisionMajor { get; init; } 
    
    /// <summary>
    /// Name of a major subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_VB4SwRvPEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Major Name")]
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? CountrySubDivisionMajorName { get; init; } 
    
    /// <summary>
    /// Name of a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_b2xG8RvPEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Minor Name")]
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? CountrySubDivisionMinorName { get; init; } 
    
    /// <summary>
    /// Nation with its own government occupying a particular territory.
    /// In accordance with ISO 3166-1.
    /// </summary>
    [IsoId("_Wd6t4cWqEeuhguwJmlgagQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
