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
[IsoId("_58do8XuQEeSVeNXcmBQ4hQ")]
[DisplayName("Payment Card")]
public record PaymentCard13
{
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_6JbG4XuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_6JbG43uQEeSVeNXcmBQ4hQ")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData9? PlainCardData { get; init; }

    /// <summary>
    /// Masked PAN to be printed the payment receipts or displayed to the cardholder. Masked digits may be absent or replaced by another character as &apos;*&apos;.
    /// </summary>
    [IsoId("_6JbG5XuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Masked PAN")]
    [IsoXmlTag("MskdPAN")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? MaskedPAN { get; init; }

    /// <summary>
    /// Type of card product.
    /// </summary>
    [IsoId("_6JbG8XuQEeSVeNXcmBQ4hQ")]
    [DisplayName("Card Product Type")]
    [IsoXmlTag("CardPdctTp")]
    public CardProductType1Code? CardProductType { get; init; }

    /// <summary>
    /// Name of card product.
    /// </summary>
    [IsoId("_gZtK8HuREeSVeNXcmBQ4hQ")]
    [DisplayName("Card Product Name")]
    [IsoXmlTag("CardPdctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductName { get; init; }
}
