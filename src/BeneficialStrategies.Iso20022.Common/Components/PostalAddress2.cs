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
/// Address of a party expressed in a formal structure, usually according to the country&apos;s postal services specifications.
/// </summary>
[IsoId("_QGSzTdp-Ed-ak6NoX_4Aeg_-931927041")]
[DisplayName("Postal Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostalAddress2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PostalAddress2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PostalAddress2( System.String reqPostCodeIdentification,System.String reqTownName,string reqCountry )
    {
        PostCodeIdentification = reqPostCodeIdentification;
        TownName = reqTownName;
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_QGSzTtp-Ed-ak6NoX_4Aeg_-663181808")]
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
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_QGckQNp-Ed-ak6NoX_4Aeg_-663181448")]
    [DisplayName("Post Code Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstCdId")]
    #endif
    [IsoXmlTag("PstCdId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax16Text PostCodeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PostCodeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PostCodeIdentification { get; init; } 
    #else
    public System.String PostCodeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_QGckQdp-Ed-ak6NoX_4Aeg_-663181328")]
    [DisplayName("Town Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TwnNm")]
    #endif
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TownName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TownName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TownName { get; init; } 
    #else
    public System.String TownName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a subdivision of a country for example, state, region, county.
    /// </summary>
    [IsoId("_QGckQtp-Ed-ak6NoX_4Aeg_-663181233")]
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
    [IsoId("_QGckQ9p-Ed-ak6NoX_4Aeg_-663181903")]
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
