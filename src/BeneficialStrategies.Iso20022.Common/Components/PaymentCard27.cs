// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment card performing the transaction.
/// </summary>
[IsoId("_pCCQUapyEeanIZ10Ka8PnA")]
[DisplayName("Payment Card")]
public record PaymentCard27
{
    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_pNEboapyEeanIZ10Ka8PnA")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_pNEbo6pyEeanIZ10Ka8PnA")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData8? PlainCardData { get; init; }

    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    [IsoId("_pNEbpapyEeanIZ10Ka8PnA")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Masked PAN to be printed on payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as &apos;*&apos;.
    /// </summary>
    [IsoId("_pNEbp6pyEeanIZ10Ka8PnA")]
    [DisplayName("Masked PAN")]
    [IsoXmlTag("MskdPAN")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? MaskedPAN { get; init; }

    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_pNEbqapyEeanIZ10Ka8PnA")]
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardBrand { get; init; }

    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_pNEbq6pyEeanIZ10Ka8PnA")]
    [DisplayName("Card Product Type")]
    [IsoXmlTag("CardPdctTp")]
    public CardProductType1Code? CardProductType { get; init; }

    /// <summary>
    /// Additionnal information to identify CardProduct.
    /// </summary>
    [IsoId("_3A70IKpyEeanIZ10Ka8PnA")]
    [DisplayName("Card Product Sub Type")]
    [IsoXmlTag("CardPdctSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductSubType { get; init; }
}
