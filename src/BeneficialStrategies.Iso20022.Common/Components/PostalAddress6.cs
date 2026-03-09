// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_QHCaJNp-Ed-ak6NoX_4Aeg_1389999614")]
[DisplayName("Postal Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostalAddress6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    [IsoId("_QHCaJdp-Ed-ak6NoX_4Aeg_1389999616")]
    [DisplayName("Address Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrTp")]
    #endif
    [IsoXmlTag("AdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressType2Code? AddressType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressType2Code? AddressType { get; init; } 
    #else
    public AddressType2Code? AddressType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_QHCaJtp-Ed-ak6NoX_4Aeg_596895935")]
    [DisplayName("Department")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dept")]
    #endif
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Department { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Department { get; init; } 
    #else
    public System.String? Department { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a sub-division of a large organisation or building.
    /// </summary>
    [IsoId("_QHCaJ9p-Ed-ak6NoX_4Aeg_1609731352")]
    [DisplayName("Sub Department")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubDept")]
    #endif
    [IsoXmlTag("SubDept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SubDepartment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubDepartment { get; init; } 
    #else
    public System.String? SubDepartment { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_QHCaKNp-Ed-ak6NoX_4Aeg_1389999977")]
    [DisplayName("Street Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtNm")]
    #endif
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? StreetName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StreetName { get; init; } 
    #else
    public System.String? StreetName { get; set; } 
    #endif
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_QHCaKdp-Ed-ak6NoX_4Aeg_1390000378")]
    [DisplayName("Building Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BldgNb")]
    #endif
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? BuildingNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BuildingNumber { get; init; } 
    #else
    public System.String? BuildingNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_QHMLINp-Ed-ak6NoX_4Aeg_1390000038")]
    [DisplayName("Post Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstCd")]
    #endif
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? PostCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostCode { get; init; } 
    #else
    public System.String? PostCode { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_QHMLIdp-Ed-ak6NoX_4Aeg_1390000069")]
    [DisplayName("Town Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwnNm")]
    #endif
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TownName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TownName { get; init; } 
    #else
    public System.String? TownName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    [IsoId("_QHMLItp-Ed-ak6NoX_4Aeg_1390000099")]
    [DisplayName("Country Sub Division")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsn")]
    #endif
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CountrySubDivision { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountrySubDivision { get; init; } 
    #else
    public System.String? CountrySubDivision { get; set; } 
    #endif
    
    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_QHMLI9p-Ed-ak6NoX_4Aeg_1389999699")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
    /// </summary>
    [IsoId("_QHMLJNp-Ed-ak6NoX_4Aeg_1389999668")]
    [DisplayName("Address Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrLine")]
    #endif
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(7)]
    public SimpleValueList<System.String> AddressLine { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
