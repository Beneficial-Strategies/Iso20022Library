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
/// Unencrypted sensitive data of a token.
/// </summary>
[IsoId("_dJ3vMZx7EeuwYeL1lHu9zw")]
[DisplayName("Token")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Token4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Surrogate value of the PAN.
    /// </summary>
    [IsoId("_dPa9kZx7EeuwYeL1lHu9zw")]
    [DisplayName("Payment Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTkn")]
    #endif
    [IsoXmlTag("PmtTkn")]
    [IsoSimpleType(IsoSimpleType.Max19NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax19NumericText? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentToken { get; init; } 
    #else
    public System.String? PaymentToken { get; set; } 
    #endif
    
    /// <summary>
    /// Expiry date of the payment token.
    /// ISO 8583 bit 14.
    /// </summary>
    [IsoId("_dPa9k5x7EeuwYeL1lHu9zw")]
    [DisplayName("Token Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknXpryDt")]
    #endif
    [IsoXmlTag("TknXpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? TokenExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? TokenExpiryDate { get; init; } 
    #else
    public System.UInt16? TokenExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a party requesting a token.
    /// </summary>
    [IsoId("_dPa9lZx7EeuwYeL1lHu9zw")]
    [DisplayName("Token Requestor Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknRqstrId")]
    #endif
    [IsoXmlTag("TknRqstrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax11NumericText? TokenRequestorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenRequestorIdentification { get; init; } 
    #else
    public System.String? TokenRequestorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Supporting information for the Token Assurance Method.
    /// </summary>
    [IsoId("_dPa9l5x7EeuwYeL1lHu9zw")]
    [DisplayName("Token Assurance Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncData")]
    #endif
    [IsoXmlTag("TknAssrncData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TokenAssuranceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenAssuranceData { get; init; } 
    #else
    public System.String? TokenAssuranceData { get; set; } 
    #endif
    
    /// <summary>
    /// Value that allows a Token Service Provider to indicate the identification and verification performed representing the binding of the payment token to the underlying PAN and cardholder.
    /// </summary>
    [IsoId("_dPa9mZx7EeuwYeL1lHu9zw")]
    [DisplayName("Token Assurance Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncMtd")]
    #endif
    [IsoXmlTag("TknAssrncMtd")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? TokenAssuranceMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenAssuranceMethod { get; init; } 
    #else
    public System.String? TokenAssuranceMethod { get; set; } 
    #endif
    
    /// <summary>
    /// A reference to the token.
    /// </summary>
    [IsoId("_6BoksJx7EeuwYeL1lHu9zw")]
    [DisplayName("Token Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknRefId")]
    #endif
    [IsoXmlTag("TknRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TokenReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenReferenceIdentification { get; init; } 
    #else
    public System.String? TokenReferenceIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
