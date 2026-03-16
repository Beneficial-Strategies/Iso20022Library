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
[IsoId("_Sqk0tgEcEeCQm6a_G2yO_w_-453349384")]
[DisplayName("Plain Card Data")]
public record PlainCardData2
{
    /// <summary>
    /// Primary Account Number (PAN) of the card, or card number.
    /// </summary>
    [IsoId("_Sqk0twEcEeCQm6a_G2yO_w_-2096174719")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public required IsoMin8Max28NumericText PAN { get; init; }

    /// <summary>
    /// Identify a card inside a set of cards with the same card number (PAN).
    /// </summary>
    [IsoId("_Sqk0uAEcEeCQm6a_G2yO_w_-1154038539")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date as from which the card can be used.
    /// </summary>
    [IsoId("_Sqk0uQEcEeCQm6a_G2yO_w_-1165137316")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public IsoISOYearMonth? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card.
    /// </summary>
    [IsoId("_Sqk0ugEcEeCQm6a_G2yO_w_2116945475")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
    public required IsoISOYearMonth ExpiryDate { get; init; }

    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [IsoId("_Sqk0uwEcEeCQm6a_G2yO_w_-1723934552")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// Magnetic track or equivalent payment card data.
    /// </summary>
    [IsoId("_Sqk0vAEcEeCQm6a_G2yO_w_1397723830")]
    [DisplayName("Track Data")]
    [IsoXmlTag("TrckData")]
    public ValueList<TrackData1> TrackData { get; init; } = [];
}
