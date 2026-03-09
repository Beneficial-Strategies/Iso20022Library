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
/// Identification of a party.
/// </summary>
[IsoId("_h0OF0YZ_EeuSbct6WWD-Ng")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification255
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentification255 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentification255( System.String reqIdentification,System.String reqNameAndLocation )
    {
        Identification = reqIdentification;
        NameAndLocation = reqNameAndLocation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_h5m8IYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    [IsoId("_h5m8I4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Assigner { get; init; } 
    #else
    public System.String? Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Country code of the acceptor.
    /// ISO 8583:87/93 bit 43 &amp; 8583:2003 bit 43-71 (when used for Acceptor Country Code)
    /// </summary>
    [IsoId("_h5m8JYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Short name of the acceptor.
    /// </summary>
    [IsoId("_h5m8J4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    [IsoId("_QBN6QCB6Eey8XKHwKquEQw")]
    [DisplayName("Legal Corporate Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglCorpNm")]
    #endif
    [IsoXmlTag("LglCorpNm")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? LegalCorporateName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LegalCorporateName { get; init; } 
    #else
    public System.String? LegalCorporateName { get; set; } 
    #endif
    
    /// <summary>
    /// Additional identification assigned by an agent to an acceptor.
    /// </summary>
    [IsoId("_h5m8KYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalIdentification { get; init; } 
    #else
    public AdditionalData1? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name and location of acceptor.  May only contain name when the location is specified elsewhere.
    /// </summary>
    [IsoId("_h5m8K4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Name And Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndLctn")]
    #endif
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax99Text NameAndLocation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NameAndLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NameAndLocation { get; init; } 
    #else
    public System.String NameAndLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the entity.
    /// ISO 8583:93 bit 43 &amp; 8583:2003 bit 43-71 (when used for acceptor address)
    /// </summary>
    [IsoId("_h5m8LYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address2? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address2? Address { get; init; } 
    #else
    public Address2? Address { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_rQShoMWLEeuhguwJmlgagQ")]
    [DisplayName("Additional Address Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAdrInf")]
    #endif
    [IsoXmlTag("AddtlAdrInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AdditionalAddressInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalAddressInformation { get; init; } 
    #else
    public System.String? AdditionalAddressInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the acceptor in latitude/longitude decimal degrees.
    /// </summary>
    [IsoId("_OnhDAMWOEeuhguwJmlgagQ")]
    [DisplayName("Geographic Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GeogcLctn")]
    #endif
    [IsoXmlTag("GeogcLctn")]
    [IsoSimpleType(IsoSimpleType.GeographicPointInDecimalDegrees)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GeographicLocation { get; init; } 
    #else
    public System.String? GeographicLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic mail address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor email address)
    /// </summary>
    [IsoId("_h5m8L4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Email")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Email")]
    #endif
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Email { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Email { get; init; } 
    #else
    public System.String? Email { get; set; } 
    #endif
    
    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor URL)
    /// </summary>
    [IsoId("_h5m8MYZ_EeuSbct6WWD-Ng")]
    [DisplayName("URL Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="URLAdr")]
    #endif
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? URLAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? URLAddress { get; init; } 
    #else
    public System.String? URLAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Collection of information that identifies  a phone number as defined by telecom services.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor phone number)
    /// </summary>
    [IsoId("_h5m8M4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhneNb")]
    #endif
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PhoneNumber { get; init; } 
    #else
    public System.String? PhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Phone number of the customer service.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor customer service phone number)
    /// </summary>
    [IsoId("_h5m8NYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Customer Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrSvc")]
    #endif
    [IsoXmlTag("CstmrSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CustomerService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerService { get; init; } 
    #else
    public System.String? CustomerService { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor, for instance sales agent name, dispute manager name.
    /// ISO 8583:2003 bit 43-71 (when used for Acceptor additional contact information)
    /// </summary>
    [IsoId("_h5m8N4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Additional Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCtctInf")]
    #endif
    [IsoXmlTag("AddtlCtctInf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? AdditionalContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalContactInformation { get; init; } 
    #else
    public System.String? AdditionalContactInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a party by its tax registration number.
    /// </summary>
    [IsoId("_h5m8OYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Tax Registration Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRegnId")]
    #endif
    [IsoXmlTag("TaxRegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TaxRegistrationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxRegistrationIdentification { get; init; } 
    #else
    public System.String? TaxRegistrationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_h5m8O4Z_EeuSbct6WWD-Ng")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_V-qukcXBEeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclData")]
    #endif
    [IsoXmlTag("LclData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalData4? LocalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalData4? LocalData { get; init; } 
    #else
    public LocalData4? LocalData { get; set; } 
    #endif
    
    /// <summary>
    /// Sponsored merchant is a merchant that uses the payment services of another entity that acts as the card acceptor.
    /// </summary>
    [IsoId("_h5m8PYZ_EeuSbct6WWD-Ng")]
    [DisplayName("Sponsored Merchant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpnsrdMrchnt")]
    #endif
    [IsoXmlTag("SpnsrdMrchnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SponsoredMerchant2? SponsoredMerchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SponsoredMerchant2? SponsoredMerchant { get; init; } 
    #else
    public SponsoredMerchant2? SponsoredMerchant { get; set; } 
    #endif
    
    
    #nullable disable
    
}
