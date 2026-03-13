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
[IsoId("_QHCaJNp-Ed-ak6NoX_4Aeg_1389999614")]
[DisplayName("Postal Address")]
public partial record PostalAddress6
{
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    [IsoId("_QHCaJdp-Ed-ak6NoX_4Aeg_1389999616")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType2Code? AddressType { get; init; } 
    
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_QHCaJtp-Ed-ak6NoX_4Aeg_596895935")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; } 
    
    /// <summary>
    /// Identification of a sub-division of a large organisation or building.
    /// </summary>
    [IsoId("_QHCaJ9p-Ed-ak6NoX_4Aeg_1609731352")]
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SubDepartment { get; init; } 
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_QHCaKNp-Ed-ak6NoX_4Aeg_1389999977")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; } 
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_QHCaKdp-Ed-ak6NoX_4Aeg_1390000378")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; } 
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_QHMLINp-Ed-ak6NoX_4Aeg_1390000038")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? PostCode { get; init; } 
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_QHMLIdp-Ed-ak6NoX_4Aeg_1390000069")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; } 
    
    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    [IsoId("_QHMLItp-Ed-ak6NoX_4Aeg_1390000099")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; } 
    
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_QHMLI9p-Ed-ak6NoX_4Aeg_1389999699")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
    /// </summary>
    [IsoId("_QHMLJNp-Ed-ak6NoX_4Aeg_1389999668")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(7)]
    public SimpleValueList<System.String> AddressLine { get; init; } = [];
    
    
    #nullable disable
    
}
