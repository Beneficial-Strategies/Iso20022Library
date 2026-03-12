// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Address of a party expressed in a formal structure, usually according to the country&apos;s postal services specifications.
/// </summary>
[IsoId("_QGSzTdp-Ed-ak6NoX_4Aeg_-931927041")]
[DisplayName("Postal Address")]
public partial record PostalAddress2
{
    #nullable enable
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_QGSzTtp-Ed-ak6NoX_4Aeg_-663181808")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_QGckQNp-Ed-ak6NoX_4Aeg_-663181448")]
    [DisplayName("Post Code Identification")]
    [IsoXmlTag("PstCdId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoMax16Text PostCodeIdentification { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_QGckQdp-Ed-ak6NoX_4Aeg_-663181328")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TownName { get; init; } 
    
    /// <summary>
    /// Identifies a subdivision of a country for example, state, region, county.
    /// </summary>
    [IsoId("_QGckQtp-Ed-ak6NoX_4Aeg_-663181233")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; } 
    
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_QGckQ9p-Ed-ak6NoX_4Aeg_-663181903")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    
    #nullable disable
    
}
