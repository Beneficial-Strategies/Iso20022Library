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
[IsoId("_ASQqINokEeC60axPepSq7g_1366752354")]
[DisplayName("Postal Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostalAddress8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PostalAddress8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PostalAddress8( string reqCountry )
    {
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    [IsoId("_ASQqIdokEeC60axPepSq7g_1252913288")]
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
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    [IsoId("_ASQqItokEeC60axPepSq7g_255840935")]
    [DisplayName("Address Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrLine")]
    #endif
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AddressLine { get; init; } = new SimpleValueList<System.String>(){};
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_ASQqI9okEeC60axPepSq7g_-741231418")]
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
    [IsoId("_ASQqJNokEeC60axPepSq7g_-1738303771")]
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
    [IsoId("_ASQqJdokEeC60axPepSq7g_1559591172")]
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
    [IsoId("_ASQqJtokEeC60axPepSq7g_562518819")]
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
    /// Identifies a subdivision of a country for example, state, region, county.
    /// </summary>
    [IsoId("_ASZ0ENokEeC60axPepSq7g_-434553534")]
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
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_ASZ0EdokEeC60axPepSq7g_-1431625887")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    
    #nullable disable
    
}
