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
/// Contains text fields in the local language.
/// </summary>
[IsoId("_cqCrUcXKEeumGdYElfgmbw")]
[DisplayName("Local Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LocalData6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LocalData6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LocalData6( string reqLanguage )
    {
        Language = reqLanguage;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The language code conforming to ISO 639-1 that identifies the language in which the fields are expressed in this component.
    /// </summary>
    [IsoId("_cuxaUcXKEeumGdYElfgmbw")]
    [DisplayName("Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lang")]
    #endif
    [IsoXmlTag("Lang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ISOMax3ALanguageCode Language { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Language { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Language { get; init; } 
    #else
    public string Language { get; set; } 
    #endif
    
    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of where the card was mailed to.
    /// </summary>
    [IsoId("_xj0VwcrcEeuQjLd-KKZrCg")]
    [DisplayName("Mailing Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MlngAdr")]
    #endif
    [IsoXmlTag("MlngAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address3? MailingAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address3? MailingAddress { get; init; } 
    #else
    public Address3? MailingAddress { get; set; } 
    #endif
    
    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the Unstructured mailing address where the card was mailed to.
    /// </summary>
    [IsoId("_zLT4AcrcEeuQjLd-KKZrCg")]
    [DisplayName("Mailing Address Unstructured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MlngAdrUstrd")]
    #endif
    [IsoXmlTag("MlngAdrUstrd")]
    [IsoSimpleType(IsoSimpleType.Max512Text)]
    [StringLength(maximumLength: 512 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax512Text? MailingAddressUnstructured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MailingAddressUnstructured { get; init; } 
    #else
    public System.String? MailingAddressUnstructured { get; set; } 
    #endif
    
    /// <summary>
    /// For cases where the card was not received, contains the local language equivalent of the postal code where the card was mailed from.
    /// </summary>
    [IsoId("_1D_Q4crcEeuQjLd-KKZrCg")]
    [DisplayName("Mailed From Postal Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MldFrPstlCd")]
    #endif
    [IsoXmlTag("MldFrPstlCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MailedFromPostalCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MailedFromPostalCode { get; init; } 
    #else
    public System.String? MailedFromPostalCode { get; set; } 
    #endif
    
    /// <summary>
    /// Local language equivalent of the Cardholder name.
    /// </summary>
    [IsoId("_cuxaU8XKEeumGdYElfgmbw")]
    [DisplayName("Cardholder Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrNm")]
    #endif
    [IsoXmlTag("CrdhldrNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderName2? CardholderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderName2? CardholderName { get; init; } 
    #else
    public CardholderName2? CardholderName { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information relevant for the settlement report.
    /// </summary>
    [IsoId("_6Mr10cooEeuuJ571wNLKkA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation22? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional local language data
    /// </summary>
    [IsoId("_ojr9YMXLEeumGdYElfgmbw")]
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
    
    
    #nullable disable
    
}
