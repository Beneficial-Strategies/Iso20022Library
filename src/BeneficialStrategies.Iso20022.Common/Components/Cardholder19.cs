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
/// Detailed information about the cardholder.
/// </summary>
[IsoId("__kNqIZ1EEeublrfU-wN95w")]
[DisplayName("Cardholder")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cardholder19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the registered cardholder name that issuer knows to be correct.
    /// </summary>
    [IsoId("__o_ccZ1EEeublrfU-wN95w")]
    [DisplayName("Cardholder Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrNm")]
    #endif
    [IsoXmlTag("CrdhldrNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardholderName3? CardholderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardholderName3? CardholderName { get; init; } 
    #else
    public CardholderName3? CardholderName { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cardholder.
    /// ISO 8583:87 bit 56 (TLV tag 03/dataset 73)
    /// ISO 8583:93 bit 112 (TLV tag 03/dataset 73)
    /// ISO 8583:2003 bit 51 (TLV tag 03/dataset 73)
    /// </summary>
    [IsoId("__o_cc51EEeublrfU-wN95w")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Credentials2? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Credentials2? Identification { get; init; } 
    #else
    public Credentials2? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Complete address of the cardholder.
    /// </summary>
    [IsoId("__o_cdZ1EEeublrfU-wN95w")]
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
    /// Contact information.
    /// ISO 8583:87 bit 56 (TLV tag 02/dataset 72)
    /// ISO 8583:93 bit 112 (TLV tag 02/dataset 72)
    /// ISO 8583:2003 bit 51 (TLV tag 02/dataset 72)
    /// </summary>
    [IsoId("__o_cd51EEeublrfU-wN95w")]
    [DisplayName("Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctInf")]
    #endif
    [IsoXmlTag("CtctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact1? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact1? ContactInformation { get; init; } 
    #else
    public Contact1? ContactInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date of birth of the party.
    /// </summary>
    [IsoId("__o_ceZ1EEeublrfU-wN95w")]
    [DisplayName("Date Of Birth")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfBirth")]
    #endif
    [IsoXmlTag("DtOfBirth")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfBirth { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfBirth { get; init; } 
    #else
    public System.DateOnly? DateOfBirth { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a cardholder that is a highly valued individual (e.g., Very Important Person).
    /// </summary>
    [IsoId("_VdeccJ1FEeublrfU-wN95w")]
    [DisplayName("High Value Customer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HghValCstmrInd")]
    #endif
    [IsoXmlTag("HghValCstmrInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? HighValueCustomerIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? HighValueCustomerIndicator { get; init; } 
    #else
    public System.String? HighValueCustomerIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Additional cardholder data.
    /// </summary>
    [IsoId("_GL2qMMXOEeumGdYElfgmbw")]
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
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_zCvrUcXNEeumGdYElfgmbw")]
    [DisplayName("Local Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclData")]
    #endif
    [IsoXmlTag("LclData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalData7? LocalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalData7? LocalData { get; init; } 
    #else
    public LocalData7? LocalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
