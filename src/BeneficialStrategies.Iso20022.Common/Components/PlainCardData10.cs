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
[IsoId("_gDy2gXr7EeSZrs_hiwNOWA")]
[DisplayName("Plain Card Data")]
public record PlainCardData10
{
    /// <summary>
    /// Primary Account Number (PAN) of the card, or surrogate of the PAN by a payment token.
    /// It correspond to the ISO 8583 field number 2.
    /// </summary>
    [IsoId("_gQUPkXr7EeSZrs_hiwNOWA")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public required IsoMin8Max28NumericText PAN { get; init; }

    /// <summary>
    /// Identify a card or a payment token inside a set of cards with the same PAN or token.
    /// </summary>
    [IsoId("_gQUPk3r7EeSZrs_hiwNOWA")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date from which the card can be used, expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_gQUPlXr7EeSZrs_hiwNOWA")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card or the payment token expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_gQUPl3r7EeSZrs_hiwNOWA")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ExpiryDate { get; init; }

    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [IsoId("_gQUPmXr7EeSZrs_hiwNOWA")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// Track issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The track value might be provided by a payment token.
    /// </summary>
    [IsoId("_gQUPm3r7EeSZrs_hiwNOWA")]
    [DisplayName("Track Data")]
    [IsoXmlTag("TrckData")]
    public ValueList<TrackData1> TrackData { get; init; } = [];

    /// <summary>
    /// Name of the cardholder stored on the card.
    /// </summary>
    [IsoId("_gQUPnXr7EeSZrs_hiwNOWA")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? CardholderName { get; init; }
}
