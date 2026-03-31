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
[IsoId("_SqR5xwEcEeCQm6a_G2yO_w_-540118057")]
[DisplayName("Plain Card Data")]
public record PlainCardData1
{
    /// <summary>
    /// Primary Account Number (PAN) of the card, or card number.
    /// </summary>
    [IsoId("_SqR5yAEcEeCQm6a_G2yO_w_-1641712788")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public required IsoMin8Max28NumericText PAN { get; init; }

    /// <summary>
    /// Identify a card inside a set of cards with the same card number (PAN).
    /// </summary>
    [IsoId("_SqR5yQEcEeCQm6a_G2yO_w_-1673683552")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date as from which the card can be used.
    /// </summary>
    [IsoId("_SqR5ygEcEeCQm6a_G2yO_w_-1981754175")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card.
    /// </summary>
    [IsoId("_SqR5ywEcEeCQm6a_G2yO_w_2121563308")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public required IsoISOYearMonth ExpiryDate { get; init; }

    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [IsoId("_SqR5zAEcEeCQm6a_G2yO_w_1887688472")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// Magnetic track or equivalent payment card data.
    /// </summary>
    [IsoId("_SqR5zQEcEeCQm6a_G2yO_w_-1854751741")]
    [DisplayName("Track Data")]
    [IsoXmlTag("TrckData")]
    public ValueList<TrackData1> TrackData { get; init; } = [];

    /// <summary>
    /// Card security code (CSC) associated with the card performing the transaction.
    /// </summary>
    [IsoId("_SqR5zgEcEeCQm6a_G2yO_w_-155223564")]
    [DisplayName("Card Security Code")]
    [IsoXmlTag("CardSctyCd")]
    public CardSecurityInformation1? CardSecurityCode { get; init; }
}
