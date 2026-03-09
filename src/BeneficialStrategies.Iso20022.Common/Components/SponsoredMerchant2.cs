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
/// Merchant using the payment services of the card acceptor. The sponsored merchant is not acting as the card acceptor; the latter remaining the only party liable for the transaction vis-à-vis the acquirer.
/// </summary>
[IsoId("_6l8gMMWPEeuhguwJmlgagQ")]
[DisplayName("Sponsored Merchant")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SponsoredMerchant2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SponsoredMerchant2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SponsoredMerchant2( PartyIdentification262 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the sponsored merchant.
    /// </summary>
    [IsoId("_6qvgocWPEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification262 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification262 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification262 Identification { get; init; } 
    #else
    public PartyIdentification262 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the full name of the sponsored merchant.
    /// </summary>
    [IsoId("_6qvgpcWPEeuhguwJmlgagQ")]
    [DisplayName("Common Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonNm")]
    #endif
    [IsoXmlTag("CmonNm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CommonName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonName { get; init; } 
    #else
    public System.String? CommonName { get; set; } 
    #endif
    
    /// <summary>
    /// Legal Corporate Name of the sponsored merchant.
    /// </summary>
    [IsoId("_p1voQCB6Eey8XKHwKquEQw")]
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
    /// Address of the sponsored merchant. 
    /// </summary>
    [IsoId("_6qvgp8WPEeuhguwJmlgagQ")]
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
    [IsoId("_CvEjdMWQEeuhguwJmlgagQ")]
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
    [IsoId("_LhmJAcWQEeuhguwJmlgagQ")]
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
    /// Additional sponsored merchant data.
    /// </summary>
    [IsoId("_1yfEgMXMEeumGdYElfgmbw")]
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
    [IsoId("_55IZgcW7EeuhguwJmlgagQ")]
    [DisplayName("Local Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclData")]
    #endif
    [IsoXmlTag("LclData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalData5? LocalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalData5? LocalData { get; init; } 
    #else
    public LocalData5? LocalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
