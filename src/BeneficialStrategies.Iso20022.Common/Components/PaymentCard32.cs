// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
[IsoId("_zazQQVFJEeyApZmLzm74zA")]
[DisplayName("Payment Card")]
public partial record PaymentCard32
{
    #nullable enable
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_zhB0EVFJEeyApZmLzm74zA")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType32? ProtectedCardData { get; init; } 
    
    /// <summary>
    /// Replacement of the message element PlainCardData by a private envelope.
    /// </summary>
    [IsoId("_zhB0E1FJEeyApZmLzm74zA")]
    [DisplayName("Private Card Data")]
    [IsoXmlTag("PrvtCardData")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? PrivateCardData { get; init; } 
    
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_zhB0FVFJEeyApZmLzm74zA")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData15? PlainCardData { get; init; } 
    
    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    [IsoId("_zhB0F1FJEeyApZmLzm74zA")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? PaymentAccountReference { get; init; } 
    
    /// <summary>
    /// Masked PAN to be printed on payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as &apos;*&apos;.
    /// </summary>
    [IsoId("_zhB0GVFJEeyApZmLzm74zA")]
    [DisplayName("Masked PAN")]
    [IsoXmlTag("MskdPAN")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? MaskedPAN { get; init; } 
    
    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    [IsoId("_zhB0G1FJEeyApZmLzm74zA")]
    [DisplayName("Issuer BIN")]
    [IsoXmlTag("IssrBIN")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? IssuerBIN { get; init; } 
    
    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_zhB0HVFJEeyApZmLzm74zA")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    public IsoMax3Text? CardCountryCode { get; init; } 
    
    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_zhB0H1FJEeyApZmLzm74zA")]
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    [IsoSimpleType(IsoSimpleType.Exact3AlphaNumericText)]
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; } 
    
    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_zhB0IVFJEeyApZmLzm74zA")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CardProductProfile { get; init; } 
    
    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_zhB0I1FJEeyApZmLzm74zA")]
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CardBrand { get; init; } 
    
    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_zhB0JVFJEeyApZmLzm74zA")]
    [DisplayName("Card Product Type")]
    [IsoXmlTag("CardPdctTp")]
    public CardProductType1Code? CardProductType { get; init; } 
    
    /// <summary>
    /// Additional information to identify CardProduct.
    /// </summary>
    [IsoId("_zhB0J1FJEeyApZmLzm74zA")]
    [DisplayName("Card Product Sub Type")]
    [IsoXmlTag("CardPdctSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CardProductSubType { get; init; } 
    
    /// <summary>
    /// True if the card may be used abroad.
    /// </summary>
    [IsoId("_zhB0KVFJEeyApZmLzm74zA")]
    [DisplayName("International Card")]
    [IsoXmlTag("IntrnlCard")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InternationalCard { get; init; } 
    
    /// <summary>
    /// Product that can be purchased with the card.
    /// </summary>
    [IsoId("_zhB0K1FJEeyApZmLzm74zA")]
    [DisplayName("Allowed Product")]
    [IsoXmlTag("AllwdPdct")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AllowedProduct { get; init; } 
    
    /// <summary>
    /// Options to the service provided by the card.
    /// </summary>
    [IsoId("_zhB0LVFJEeyApZmLzm74zA")]
    [DisplayName("Service Option")]
    [IsoXmlTag("SvcOptn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceOption { get; init; } 
    
    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_zhB0L1FJEeyApZmLzm74zA")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalCardData { get; init; } 
    
    
    #nullable disable
    
}
