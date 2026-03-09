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
/// Electronic money product that provides the cardholder with a portable and specialised computer device, which typically contains a microprocessor.
/// </summary>
[IsoId("_QRxDedp-Ed-ak6NoX_4Aeg_137953506")]
[DisplayName("Payment Card")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentCard2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentCard2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentCard2( CardType1Code reqType,System.String reqNumber,System.String reqHolderName,System.UInt16 reqExpiryDate )
    {
        Type = reqType;
        Number = reqNumber;
        HolderName = reqHolderName;
        ExpiryDate = reqExpiryDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of card, eg, credit card.
    /// </summary>
    [IsoId("_QRxDetp-Ed-ak6NoX_4Aeg_137953532")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardType1Code Type { get; init; } 
    #else
    public CardType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Number embossed on a card that links the card to the account owner and account servicer.
    /// </summary>
    [IsoId("_QRxDe9p-Ed-ak6NoX_4Aeg_137953548")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Number { get; init; } 
    #else
    public System.String Number { get; set; } 
    #endif
    
    /// <summary>
    /// Party entitled by a card issuer to use a card.
    /// </summary>
    [IsoId("_QRxDfNp-Ed-ak6NoX_4Aeg_137953566")]
    [DisplayName("Holder Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HldrNm")]
    #endif
    [IsoXmlTag("HldrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text HolderName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String HolderName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String HolderName { get; init; } 
    #else
    public System.String HolderName { get; set; } 
    #endif
    
    /// <summary>
    /// Year and month the card is available for use.
    /// </summary>
    [IsoId("_QR60cNp-Ed-ak6NoX_4Aeg_137953583")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYearMonth? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? StartDate { get; init; } 
    #else
    public System.UInt16? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Year and month the card expires.
    /// </summary>
    [IsoId("_QR60cdp-Ed-ak6NoX_4Aeg_137953601")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOYearMonth ExpiryDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt16 ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16 ExpiryDate { get; init; } 
    #else
    public System.UInt16 ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    [IsoId("_QR60ctp-Ed-ak6NoX_4Aeg_137953626")]
    [DisplayName("Card Issuer Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardIssrNm")]
    #endif
    [IsoXmlTag("CardIssrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardIssuerName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardIssuerName { get; init; } 
    #else
    public System.String? CardIssuerName { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues a payment card, as expressed by a numeric identification of the card issuer according to ISO/IEC 7812-1.
    /// </summary>
    [IsoId("_QR60c9p-Ed-ak6NoX_4Aeg_137953643")]
    [DisplayName("Card Issuer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardIssrId")]
    #endif
    [IsoXmlTag("CardIssrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? CardIssuerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? CardIssuerIdentification { get; init; } 
    #else
    public PartyIdentification2Choice_? CardIssuerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Security code written on, or in, the card.
    /// </summary>
    [IsoId("_QR60dNp-Ed-ak6NoX_4Aeg_137953934")]
    [DisplayName("Security Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyCd")]
    #endif
    [IsoXmlTag("SctyCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecurityCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityCode { get; init; } 
    #else
    public System.String? SecurityCode { get; set; } 
    #endif
    
    /// <summary>
    /// Number distinguishing two or more payment cards with the same account number.
    /// </summary>
    [IsoId("_QR60ddp-Ed-ak6NoX_4Aeg_137953951")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Text? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceNumber { get; init; } 
    #else
    public System.String? SequenceNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
