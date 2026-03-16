// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensible data associated with the payment card performing the transaction.
/// </summary>
[IsoId("_l24gIY0TEeWRYffwL7E13A")]
[DisplayName("Plain Card Data")]
public record PlainCardData15
{
    /// <summary>
    /// Primary Account Number (PAN) of the card, or surrogate of the PAN by a payment token.
    /// </summary>
    [IsoId("_mBWqwY0TEeWRYffwL7E13A")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public required IsoMin8Max28NumericText PAN { get; init; }

    /// <summary>
    /// Identify a card or a payment token inside a set of cards with the same PAN or token.
    /// </summary>
    [IsoId("_mBWqw40TEeWRYffwL7E13A")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date from which the card can be used, expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_mBWqxY0TEeWRYffwL7E13A")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card or the payment token expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_mBWqx40TEeWRYffwL7E13A")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public required IsoMax10Text ExpiryDate { get; init; }

    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [IsoId("_mBWqyY0TEeWRYffwL7E13A")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// ISO track 1 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_QluaMI0UEeWRYffwL7E13A")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max76Text)]
    [StringLength(maximumLength: 76, MinimumLength = 1)]
    public IsoMax76Text? Track1 { get; init; }

    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_WnHU4I0UEeWRYffwL7E13A")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck2")]
    [IsoSimpleType(IsoSimpleType.Max37Text)]
    [StringLength(maximumLength: 37, MinimumLength = 1)]
    public IsoMax37Text? Track2 { get; init; }

    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_bE-AQI0UEeWRYffwL7E13A")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max104Text)]
    [StringLength(maximumLength: 104, MinimumLength = 1)]
    public IsoMax104Text? Track3 { get; init; }

    /// <summary>
    /// Name of the cardholder stored on the card.
    /// </summary>
    [IsoId("_mBWqzY0TEeWRYffwL7E13A")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? CardholderName { get; init; }
}
