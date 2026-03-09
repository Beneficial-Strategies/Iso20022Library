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
[IsoId("_ApLWwY08EeWPUZwhUA4U-w")]
[DisplayName("Payment Card")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentCard20
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
    [IsoId("_A0M7AY08EeWPUZwhUA4U-w")]
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
    [IsoId("_A0M7A408EeWPUZwhUA4U-w")]
    [DisplayName("Plain Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlainCardData")]
    #endif
    [IsoXmlTag("PlainCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData16? PlainCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData16? PlainCardData { get; init; } 
    #else
    public PlainCardData16? PlainCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    [IsoId("_lFSHcI08EeWPUZwhUA4U-w")]
    [DisplayName("Payment Account Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtAcctRef")]
    #endif
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? PaymentAccountReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PaymentAccountReference { get; init; } 
    #else
    public System.String? PaymentAccountReference { get; set; } 
    #endif
    
    /// <summary>
    /// Masked PAN to be printed the payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as &apos;*&apos;.
    /// </summary>
    [IsoId("_A0M7BY08EeWPUZwhUA4U-w")]
    [DisplayName("Masked PAN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MskdPAN")]
    #endif
    [IsoXmlTag("MskdPAN")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? MaskedPAN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaskedPAN { get; init; } 
    #else
    public System.String? MaskedPAN { get; set; } 
    #endif
    
    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    [IsoId("_A0M7B408EeWPUZwhUA4U-w")]
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
    [IsoId("_A0M7CY08EeWPUZwhUA4U-w")]
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
    [IsoId("_A0M7C408EeWPUZwhUA4U-w")]
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
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_A0M7DY08EeWPUZwhUA4U-w")]
    [DisplayName("Card Product Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPdctPrfl")]
    #endif
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardProductProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardProductProfile { get; init; } 
    #else
    public System.String? CardProductProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_A0M7D408EeWPUZwhUA4U-w")]
    [DisplayName("Card Brand")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardBrnd")]
    #endif
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardBrand { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardBrand { get; init; } 
    #else
    public System.String? CardBrand { get; set; } 
    #endif
    
    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_A0M7EY08EeWPUZwhUA4U-w")]
    [DisplayName("Card Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardPdctTp")]
    #endif
    [IsoXmlTag("CardPdctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardProductType1Code? CardProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardProductType1Code? CardProductType { get; init; } 
    #else
    public CardProductType1Code? CardProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_A0M7E408EeWPUZwhUA4U-w")]
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
