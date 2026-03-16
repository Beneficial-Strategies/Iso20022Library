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
[IsoId("_eTiqgY0TEeWRYffwL7E13A")]
[DisplayName("Payment Card")]
public record PaymentCard21
{
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_ed-Y4Y0TEeWRYffwL7E13A")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_ed-Y440TEeWRYffwL7E13A")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData15? PlainCardData { get; init; }

    /// <summary>
    /// Unique reference to the card, used by both merchants and acquirers to link tokenized and non-tokenized transactions associated to the same underlying card.
    /// </summary>
    [IsoId("_ncGVAI0UEeWRYffwL7E13A")]
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PaymentAccountReference { get; init; }

    /// <summary>
    /// Bank identifier number of the issuer for routing purpose.
    /// </summary>
    [IsoId("_ed-Y5Y0TEeWRYffwL7E13A")]
    [DisplayName("Issuer BIN")]
    [IsoXmlTag("IssrBIN")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? IssuerBIN { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_ed-Y540TEeWRYffwL7E13A")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? CardCountryCode { get; init; }

    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_ed-Y6Y0TEeWRYffwL7E13A")]
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    [IsoSimpleType(IsoSimpleType.Exact3AlphaNumericText)]
    public IsoExact3AlphaNumericText? CardCurrencyCode { get; init; }

    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_ed-Y640TEeWRYffwL7E13A")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardProductProfile { get; init; }

    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_ed-Y7Y0TEeWRYffwL7E13A")]
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardBrand { get; init; }

    /// <summary>
    /// True if the card may be used abroad.
    /// </summary>
    [IsoId("_38P3kJZqEeWuSaWgzo19MQ")]
    [DisplayName("International Card")]
    [IsoXmlTag("IntrnlCard")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InternationalCard { get; init; }

    /// <summary>
    /// Product that can be purchased with the card.
    /// </summary>
    [IsoId("_0bwMUJZqEeWuSaWgzo19MQ")]
    [DisplayName("Allowed Product")]
    [IsoXmlTag("AllwdPdct")]
    public SimpleValueList<IsoMax70Text> AllowedProduct { get; init; } = [];

    /// <summary>
    /// Options to the service provided by the card.
    /// </summary>
    [IsoId("_-EExcJZqEeWuSaWgzo19MQ")]
    [DisplayName("Service Option")]
    [IsoXmlTag("SvcOptn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceOption { get; init; }

    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_ed-Y740TEeWRYffwL7E13A")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalCardData { get; init; }
}
