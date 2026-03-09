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
/// Structured postal address in the local language.
/// </summary>
[IsoId("_sB268cWrEeuhguwJmlgagQ")]
[DisplayName("Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Address3
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
    [IsoId("_sGjNscWrEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrLine1")]
    #endif
    [IsoXmlTag("AdrLine1")]
    [IsoSimpleType(IsoSimpleType.Max200Text)]
    [StringLength(maximumLength: 200 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax200Text? AddressLine1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AddressLine1 { get; init; } 
    #else
    public System.String? AddressLine1 { get; set; } 
    #endif
    
    /// <summary>
    /// Second line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_sGjNs8WrEeuhguwJmlgagQ")]
    [DisplayName("Address Line")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrLine2")]
    #endif
    [IsoXmlTag("AdrLine2")]
    [IsoSimpleType(IsoSimpleType.Max200Text)]
    [StringLength(maximumLength: 200 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax200Text? AddressLine2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AddressLine2 { get; init; } 
    #else
    public System.String? AddressLine2 { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_sGjNtcWrEeuhguwJmlgagQ")]
    [DisplayName("Street Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrtNm")]
    #endif
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max200Text)]
    [StringLength(maximumLength: 200 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax200Text? StreetName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StreetName { get; init; } 
    #else
    public System.String? StreetName { get; set; } 
    #endif
    
    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_sGjNt8WrEeuhguwJmlgagQ")]
    [DisplayName("Building Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BldgNb")]
    #endif
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BuildingNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BuildingNumber { get; init; } 
    #else
    public System.String? BuildingNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_sGjNucWrEeuhguwJmlgagQ")]
    [DisplayName("Postal Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstlCd")]
    #endif
    [IsoXmlTag("PstlCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PostalCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostalCode { get; init; } 
    #else
    public System.String? PostalCode { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_sGjNu8WrEeuhguwJmlgagQ")]
    [DisplayName("Town Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwnNm")]
    #endif
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100Text? TownName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TownName { get; init; } 
    #else
    public System.String? TownName { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the country sub division minor.
    /// </summary>
    [IsoId("_ztabkB1GEey8XKHwKquEQw")]
    [DisplayName("Country Sub Division Minor Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMnrNm")]
    #endif
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100Text? CountrySubDivisionMinorName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountrySubDivisionMinorName { get; init; } 
    #else
    public System.String? CountrySubDivisionMinorName { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the country sub division major.
    /// </summary>
    [IsoId("_6C5W8B1GEey8XKHwKquEQw")]
    [DisplayName("Country Sub Division Major Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsnMjrNm")]
    #endif
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    [IsoSimpleType(IsoSimpleType.Max100Text)]
    [StringLength(maximumLength: 100 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100Text? CountrySubDivisionMajorName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountrySubDivisionMajorName { get; init; } 
    #else
    public System.String? CountrySubDivisionMajorName { get; set; } 
    #endif
    
    /// <summary>
    /// Nation with its own government occupying a particular territory.
    /// In accordance with ISO 3166-1.
    /// </summary>
    [IsoId("_sGjNwcWrEeuhguwJmlgagQ")]
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
