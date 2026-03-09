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
/// Payment card performing the transaction.
/// </summary>
[IsoId("_46pQwXr6EeSZrs_hiwNOWA")]
[DisplayName("Payment Card")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentCard12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_5HA40Xr6EeSZrs_hiwNOWA")]
    [DisplayName("Protected Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdCardData")]
    #endif
    [IsoXmlTag("PrtctdCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedCardData { get; init; } 
    #else
    public ContentInformationType10? ProtectedCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_5HA403r6EeSZrs_hiwNOWA")]
    [DisplayName("Plain Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlainCardData")]
    #endif
    [IsoXmlTag("PlainCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData10? PlainCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData10? PlainCardData { get; init; } 
    #else
    public PlainCardData10? PlainCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    [IsoId("_5HA41Xr6EeSZrs_hiwNOWA")]
    [DisplayName("Issuer BIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrBIN")]
    #endif
    [IsoXmlTag("IssrBIN")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? IssuerBIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerBIN { get; init; } 
    #else
    public System.String? IssuerBIN { get; set; } 
    #endif
    
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_5HA413r6EeSZrs_hiwNOWA")]
    [DisplayName("Card Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardCtryCd")]
    #endif
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Text? CardCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardCountryCode { get; init; } 
    #else
    public System.String? CardCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_5HA42Xr6EeSZrs_hiwNOWA")]
    [DisplayName("Card Currency Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardCcyCd")]
    #endif
    [IsoXmlTag("CardCcyCd")]
    [IsoSimpleType(IsoSimpleType.Exact3AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardCurrencyCode { get; init; } 
    #else
    public System.String? CardCurrencyCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_5HA433r6EeSZrs_hiwNOWA")]
    [DisplayName("Additional Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlCardData")]
    #endif
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalCardData { get; init; } 
    #else
    public System.String? AdditionalCardData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
