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
/// Structured postal address.
/// </summary>
[IsoId("_WZgu8cWqEeuhguwJmlgagQ")]
[DisplayName("Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Address2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// First line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_Wd6t0cWqEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrLine1")]
    #endif
    [IsoXmlTag("AdrLine1")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? AddressLine1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AddressLine1 { get; init; } 
    #else
    public System.String? AddressLine1 { get; set; } 
    #endif
    
    /// <summary>
    /// Second line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_Wd6t08WqEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrLine2")]
    #endif
    [IsoXmlTag("AdrLine2")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? AddressLine2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AddressLine2 { get; init; } 
    #else
    public System.String? AddressLine2 { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_Wd6t1cWqEeuhguwJmlgagQ")]
    [DisplayName("Street Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtNm")]
    #endif
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? StreetName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StreetName { get; init; } 
    #else
    public System.String? StreetName { get; set; } 
    #endif
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_Wd6t18WqEeuhguwJmlgagQ")]
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
    [IsoId("_Wd6t2cWqEeuhguwJmlgagQ")]
    [DisplayName("Postal Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlCd")]
    #endif
    [IsoXmlTag("PstlCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? PostalCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostalCode { get; init; } 
    #else
    public System.String? PostalCode { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_Wd6t28WqEeuhguwJmlgagQ")]
    [DisplayName("Town Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwnNm")]
    #endif
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? TownName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TownName { get; init; } 
    #else
    public System.String? TownName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a minor subdivision of a country, for instance county, prefecture.
    /// In accordance with ISO 3166-2 or the local authority.
    /// </summary>
    [IsoId("_Wd6t3cWqEeuhguwJmlgagQ")]
    [DisplayName("Country Sub Division Minor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMnr")]
    #endif
    [IsoXmlTag("CtrySubDvsnMnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOCountrySubDivisionCode? CountrySubDivisionMinor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountrySubDivisionMinor { get; init; } 
    #else
    public string? CountrySubDivisionMinor { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a major subdivision of a country, for instance state, province.
    /// In accordance with ISO 3166-2 or the local authority.
    /// </summary>
    [IsoId("_Wd6t38WqEeuhguwJmlgagQ")]
    [DisplayName("Country Sub Division Major")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMjr")]
    #endif
    [IsoXmlTag("CtrySubDvsnMjr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOCountrySubDivisionCode? CountrySubDivisionMajor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountrySubDivisionMajor { get; init; } 
    #else
    public string? CountrySubDivisionMajor { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a major subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_VB4SwRvPEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Major Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMjrNm")]
    #endif
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? CountrySubDivisionMajorName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountrySubDivisionMajorName { get; init; } 
    #else
    public System.String? CountrySubDivisionMajorName { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_b2xG8RvPEey2RdTw-AkXzg")]
    [DisplayName("Country Sub Division Minor Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMnrNm")]
    #endif
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? CountrySubDivisionMinorName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountrySubDivisionMinorName { get; init; } 
    #else
    public System.String? CountrySubDivisionMinorName { get; set; } 
    #endif
    
    /// <summary>
    /// Nation with its own government occupying a particular territory.
    /// In accordance with ISO 3166-1.
    /// </summary>
    [IsoId("_Wd6t4cWqEeuhguwJmlgagQ")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOMax3ACountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    
    #nullable disable
    
}
