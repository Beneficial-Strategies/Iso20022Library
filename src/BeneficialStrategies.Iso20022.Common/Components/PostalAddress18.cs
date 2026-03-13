// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services or in free format text.
/// </summary>
[IsoId("_LASmYS7HEeWc7f-D6ByqMg")]
[DisplayName("Postal Address")]
public partial record PostalAddress18
{
    #nullable enable
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    [IsoId("_LLLAsS7HEeWc7f-D6ByqMg")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> AddressLine { get; init; } = [];
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_LLLAsy7HEeWc7f-D6ByqMg")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_LLLAtS7HEeWc7f-D6ByqMg")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_LLLAty7HEeWc7f-D6ByqMg")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? PostCode { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_LLLAuS7HEeWc7f-D6ByqMg")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TownName { get; init; } 
    
    /// <summary>
    /// Identifies a subdivision of a country, for instance state, region, county.
    /// </summary>
    [IsoId("_LLLAuy7HEeWc7f-D6ByqMg")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> CountrySubDivision { get; init; } = [];
    
    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_LLLAvS7HEeWc7f-D6ByqMg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    
    #nullable disable
    
}
