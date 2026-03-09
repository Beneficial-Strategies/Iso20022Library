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
[IsoId("_6iOyUWkiEeSTIuB9A-QJ6g")]
[DisplayName("Payment Card")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentCard10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_6vP6oWkiEeSTIuB9A-QJ6g")]
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
    [IsoId("_6vP6o2kiEeSTIuB9A-QJ6g")]
    [DisplayName("Plain Card Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlainCardData")]
    #endif
    [IsoXmlTag("PlainCardData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData8? PlainCardData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData8? PlainCardData { get; init; } 
    #else
    public PlainCardData8? PlainCardData { get; set; } 
    #endif
    
    /// <summary>
    /// Masked PAN to be printed on payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as &apos;*&apos;.
    /// </summary>
    [IsoId("_rfEfsGkjEeSTIuB9A-QJ6g")]
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
    /// Brand name of the card.
    /// </summary>
    [IsoId("_j8-MkGtaEeSKOvNNYJQdoQ")]
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
    [IsoId("_MxRXcGtZEeSKOvNNYJQdoQ")]
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
    
    
    #nullable disable
    
}
