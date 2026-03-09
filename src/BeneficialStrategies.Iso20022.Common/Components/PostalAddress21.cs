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
[IsoId("_E4FW4SFyEeW9XJWqfgXIIA")]
[DisplayName("Postal Address")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostalAddress21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PostalAddress21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PostalAddress21( string reqCountry )
    {
        Country = reqCountry;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of address.
    /// </summary>
    [IsoId("_FUWcIyFyEeW9XJWqfgXIIA")]
    [DisplayName("Address Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrTp")]
    #endif
    [IsoXmlTag("AdrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressType2Choice_? AddressType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressType2Choice_? AddressType { get; init; } 
    #else
    public AddressType2Choice_? AddressType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether mail should be sent to the address.
    /// </summary>
    [IsoId("_FUWcJSFyEeW9XJWqfgXIIA")]
    [DisplayName("Mailing Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MlngInd")]
    #endif
    [IsoXmlTag("MlngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MailingIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MailingIndicator { get; init; } 
    #else
    public System.String? MailingIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the address is the official address of the party.
    /// </summary>
    [IsoId("_FUWcJyFyEeW9XJWqfgXIIA")]
    [DisplayName("Registration Address Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAdrInd")]
    #endif
    [IsoXmlTag("RegnAdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RegistrationAddressIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationAddressIndicator { get; init; } 
    #else
    public System.String? RegistrationAddressIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// When the individual resides at another person’s address, the name of the other person.
    /// </summary>
    [IsoId("_4dKfkDnhEeW7UoCHqpiMaQ")]
    [DisplayName("Care Of")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CareOf")]
    #endif
    [IsoXmlTag("CareOf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CareOf { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CareOf { get; init; } 
    #else
    public System.String? CareOf { get; set; } 
    #endif
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    [IsoId("_vkmOWDnfEeWSyLR5Z9BEKA")]
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
    /// Name of the street or thoroughfare.
    /// </summary>
    [IsoId("_vkmOWTnfEeWSyLR5Z9BEKA")]
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
    /// Number that identifies the position of the building on a street.
    /// </summary>
    [IsoId("_vkmOWjnfEeWSyLR5Z9BEKA")]
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
    [IsoId("_AzwB8TngEeWSyLR5Z9BEKA")]
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
    /// Post box number of the addressee within the residential or company building.
    /// </summary>
    [IsoId("_FeMX0DngEeWSyLR5Z9BEKA")]
    [DisplayName("Post Box")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstBx")]
    #endif
    [IsoXmlTag("PstBx")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? PostBox { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostBox { get; init; } 
    #else
    public System.String? PostBox { get; set; } 
    #endif
    
    /// <summary>
    /// Side or wing of the building, for example, ‘wing A’.
    /// </summary>
    [IsoId("_HSPIUDngEeWSyLR5Z9BEKA")]
    [DisplayName("Side In Building")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SdInBldg")]
    #endif
    [IsoXmlTag("SdInBldg")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SideInBuilding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SideInBuilding { get; init; } 
    #else
    public System.String? SideInBuilding { get; set; } 
    #endif
    
    /// <summary>
    /// Floor or storey within the building.
    /// </summary>
    [IsoId("_LcrvgTngEeWSyLR5Z9BEKA")]
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
    /// Identification of the suite or apartment.
    /// </summary>
    [IsoId("_R48BQDngEeWSyLR5Z9BEKA")]
    [DisplayName("Suite Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SuiteId")]
    #endif
    [IsoXmlTag("SuiteId")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? SuiteIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SuiteIdentification { get; init; } 
    #else
    public System.String? SuiteIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_vkmOWznfEeWSyLR5Z9BEKA")]
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
    /// Name of a district, that is, a part of the town or region.
    /// </summary>
    [IsoId("_vkmOXDnfEeWSyLR5Z9BEKA")]
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
    /// Name of the village.
    /// </summary>
    [IsoId("_S0S2QDngEeWSyLR5Z9BEKA")]
    [DisplayName("Village")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vllg")]
    #endif
    [IsoXmlTag("Vllg")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Village { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Village { get; init; } 
    #else
    public System.String? Village { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the town or city.
    /// </summary>
    [IsoId("_vkmOXTnfEeWSyLR5Z9BEKA")]
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
    /// Name of the state, county or country sub-division.
    /// </summary>
    [IsoId("_calbEDngEeWSyLR5Z9BEKA")]
    [DisplayName("State")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stat")]
    #endif
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? State { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? State { get; init; } 
    #else
    public System.String? State { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the address.
    /// </summary>
    [IsoId("_vkmOXznfEeWSyLR5Z9BEKA")]
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
