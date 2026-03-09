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
[IsoId("_kmyhBO5NEeCisYr99QEiWA_861958296")]
[DisplayName("Postal Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostalAddress9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PostalAddress9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PostalAddress9( System.DateOnly reqValidFrom )
    {
        ValidFrom = reqValidFrom;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_km8SAO5NEeCisYr99QEiWA_855284979")]
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
    [IsoId("_km8SAe5NEeCisYr99QEiWA_1616050132")]
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
    [IsoId("_km8SAu5NEeCisYr99QEiWA_-393906726")]
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
    /// Name of a built-up area, with defined boundaries, and a local government.|.
    /// </summary>
    [IsoId("_km8SA-5NEeCisYr99QEiWA_-1197741420")]
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
    [IsoId("_km8SBO5NEeCisYr99QEiWA_-743654151")]
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
    [IsoId("_knFb8O5NEeCisYr99QEiWA_1866473794")]
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
    /// Starting date from which the address is valid.
    /// </summary>
    [IsoId("_knFb8e5NEeCisYr99QEiWA_-753427361")]
    [DisplayName("Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldFr")]
    #endif
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ValidFrom { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ValidFrom { get; init; } 
    #else
    public System.DateOnly ValidFrom { get; set; } 
    #endif
    
    
    #nullable disable
    
}
