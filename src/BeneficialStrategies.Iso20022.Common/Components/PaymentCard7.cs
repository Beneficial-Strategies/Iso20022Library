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
[IsoId("_hnjrQS_jEeO4w-IWHJMI9g")]
[DisplayName("Payment Card")]
public record PaymentCard7
{
    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_h3BqoS_jEeO4w-IWHJMI9g")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType7? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_h3Bqoy_jEeO4w-IWHJMI9g")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData4? PlainCardData { get; init; }

    /// <summary>
    /// Country code assigned to the card by the card issuer.
    /// </summary>
    [IsoId("_h3BqpS_jEeO4w-IWHJMI9g")]
    [DisplayName("Card Country Code")]
    [IsoXmlTag("CardCtryCd")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3, MinimumLength = 1)]
    public IsoMax3Text? CardCountryCode { get; init; }

    /// <summary>
    /// Currency code of the card issuer (ISO 4217 numeric code).
    /// </summary>
    [IsoId("_9xzTcC_jEeO4w-IWHJMI9g")]
    [DisplayName("Card Currency Code")]
    [IsoXmlTag("CardCcyCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? CardCurrencyCode { get; init; }

    /// <summary>
    /// Defines a category of cards related to the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_h3Bqpy_jEeO4w-IWHJMI9g")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? CardProductProfile { get; init; }

    /// <summary>
    /// Brand name of the card.
    /// </summary>
    [IsoId("_h3BqqS_jEeO4w-IWHJMI9g")]
    [DisplayName("Card Brand")]
    [IsoXmlTag("CardBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CardBrand { get; init; }

    /// <summary>
    /// Additional card issuer specific data.
    /// </summary>
    [IsoId("_h3Bqqy_jEeO4w-IWHJMI9g")]
    [DisplayName("Additional Card Data")]
    [IsoXmlTag("AddtlCardData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AdditionalCardData { get; init; }
}
