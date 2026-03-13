// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_lLLsQdLNEeSdq5yU2aaSNw")]
[DisplayName("Postal Address")]
public partial record PostalAddress19
{
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    [IsoId("_lVJgk9LNEeSdq5yU2aaSNw")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType2Code? AddressType { get; init; } 
    
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_lVJgldLNEeSdq5yU2aaSNw")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; } 
    
    /// <summary>
    /// Identification of a sub-division of a large organisation or building.
    /// </summary>
    [IsoId("_lVJgl9LNEeSdq5yU2aaSNw")]
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SubDepartment { get; init; } 
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_lVJgmdLNEeSdq5yU2aaSNw")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_lVJgm9LNEeSdq5yU2aaSNw")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_lVJgndLNEeSdq5yU2aaSNw")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? PostCode { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_lVJgn9LNEeSdq5yU2aaSNw")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; } 
    
    /// <summary>
    /// Specific location name within the town.
    /// </summary>
    [IsoId("_WQh1YdLOEeSdq5yU2aaSNw")]
    [DisplayName("Town Location Name")]
    [IsoXmlTag("TwnLctnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TownLocationName { get; init; } 
    
    /// <summary>
    /// Identifies a subdivision within a country sub-division.
    /// </summary>
    [IsoId("_n0fQ09LNEeSdq5yU2aaSNw")]
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DistrictName { get; init; } 
    
    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    [IsoId("_lVJgodLNEeSdq5yU2aaSNw")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; } 
    
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_lVJgo9LNEeSdq5yU2aaSNw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
    /// </summary>
    [IsoId("_lVJgpdLNEeSdq5yU2aaSNw")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(7)]
    public SimpleValueList<System.String> AddressLine { get; init; } = [];
    
    
    #nullable disable
    
}
