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
[IsoId("_djqi4YHaEeu02oZZRFgg6A")]
[DisplayName("Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentification254
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    [IsoId("_dozhkYHaEeu02oZZRFgg6A")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the entity assigning an identification to the acceptor.
    /// </summary>
    [IsoId("_dozhk4HaEeu02oZZRFgg6A")]
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
    /// ISO 8583 bit 19
    /// </summary>
    [IsoId("_dozhlYHaEeu02oZZRFgg6A")]
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
    [IsoId("_dozhl4HaEeu02oZZRFgg6A")]
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
    /// Legal Corporate Name of the party
    /// </summary>
    [IsoId("_RyTn8CB7Eey8XKHwKquEQw")]
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
    [IsoId("_dozhmYHaEeu02oZZRFgg6A")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalIdentification { get; init; } 
    #else
    public System.String? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name and location of acceptor.  May only contain name and not location if the location is specified elsewhere.
    /// </summary>
    [IsoId("_dozhm4HaEeu02oZZRFgg6A")]
    [DisplayName("Name And Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndLctn")]
    #endif
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? NameAndLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameAndLocation { get; init; } 
    #else
    public System.String? NameAndLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the entity.
    /// </summary>
    [IsoId("_dozhnYHaEeu02oZZRFgg6A")]
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
    [IsoId("_jyHtpMWQEeuhguwJmlgagQ")]
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
    [IsoId("_lbUgEcWQEeuhguwJmlgagQ")]
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
    /// </summary>
    [IsoId("_dozhn4HaEeu02oZZRFgg6A")]
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
    /// </summary>
    [IsoId("_dozhoYHaEeu02oZZRFgg6A")]
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
    /// </summary>
    [IsoId("_dozho4HaEeu02oZZRFgg6A")]
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
    /// </summary>
    [IsoId("_dozhpYHaEeu02oZZRFgg6A")]
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
    /// </summary>
    [IsoId("_dozhp4HaEeu02oZZRFgg6A")]
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
    [IsoId("_dozhqYHaEeu02oZZRFgg6A")]
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
    [IsoId("_ovZmEIHbEeu02oZZRFgg6A")]
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
    [IsoId("_hIH1ocXJEeumGdYElfgmbw")]
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
    [IsoId("_sc9c8YHbEeu02oZZRFgg6A")]
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
