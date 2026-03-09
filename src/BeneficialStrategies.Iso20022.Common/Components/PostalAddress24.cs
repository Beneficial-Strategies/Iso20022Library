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
[IsoId("_9XYD524-EeiU9cctagi5ow")]
[DisplayName("Postal Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostalAddress24
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
    [IsoId("_9gwpY24-EeiU9cctagi5ow")]
    [DisplayName("Address Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrTp")]
    #endif
    [IsoXmlTag("AdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressType3Choice_? AddressType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressType3Choice_? AddressType { get; init; } 
    #else
    public AddressType3Choice_? AddressType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_9gwpZW4-EeiU9cctagi5ow")]
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
    [IsoId("_9gwpZ24-EeiU9cctagi5ow")]
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
    [IsoId("_9gwpaW4-EeiU9cctagi5ow")]
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
    [IsoId("_9gwpa24-EeiU9cctagi5ow")]
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
    /// Name of the building or house.
    /// </summary>
    [IsoId("_ZOcTkG5OEeiU9cctagi5ow")]
    [DisplayName("Building Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BldgNm")]
    #endif
    [IsoXmlTag("BldgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BuildingName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BuildingName { get; init; } 
    #else
    public System.String? BuildingName { get; set; } 
    #endif
    
    /// <summary>
    /// Floor or storey within a building.
    /// </summary>
    [IsoId("_F1IHQ3RpEeiH1ZOt2UD8vQ")]
    [DisplayName("Floor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Flr")]
    #endif
    [IsoXmlTag("Flr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Floor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Floor { get; init; } 
    #else
    public System.String? Floor { get; set; } 
    #endif
    
    /// <summary>
    /// Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for.
    /// </summary>
    [IsoId("_F1IHRHRpEeiH1ZOt2UD8vQ")]
    [DisplayName("Post Box")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstBx")]
    #endif
    [IsoXmlTag("PstBx")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? PostBox { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostBox { get; init; } 
    #else
    public System.String? PostBox { get; set; } 
    #endif
    
    /// <summary>
    /// Building room number.
    /// </summary>
    [IsoId("_F1IHRXRpEeiH1ZOt2UD8vQ")]
    [DisplayName("Room")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Room")]
    #endif
    [IsoXmlTag("Room")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Room { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Room { get; init; } 
    #else
    public System.String? Room { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_9gwpbW4-EeiU9cctagi5ow")]
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
    [IsoId("_9gwpb24-EeiU9cctagi5ow")]
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
    /// Specific location name within the town.
    /// </summary>
    [IsoId("_rvZGQ25OEeiU9cctagi5ow")]
    [DisplayName("Town Location Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwnLctnNm")]
    #endif
    [IsoXmlTag("TwnLctnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TownLocationName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TownLocationName { get; init; } 
    #else
    public System.String? TownLocationName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a subdivision within a country sub-division.
    /// </summary>
    [IsoId("_rvZGRG5OEeiU9cctagi5ow")]
    [DisplayName("District Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrctNm")]
    #endif
    [IsoXmlTag("DstrctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DistrictName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DistrictName { get; init; } 
    #else
    public System.String? DistrictName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    [IsoId("_9gwpcW4-EeiU9cctagi5ow")]
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
    [IsoId("_9gwpc24-EeiU9cctagi5ow")]
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
    [IsoId("_9gwpdW4-EeiU9cctagi5ow")]
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
