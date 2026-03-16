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
[IsoId("_qvjwYYp3EeS3NqNpgnMh2w")]
[DisplayName("Plain Card Data")]
public record PlainCardData14
{
    /// <summary>
    /// Primary Account Number (PAN) of the card.
    /// </summary>
    [IsoId("_q77YcYp3EeS3NqNpgnMh2w")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public IsoMin8Max28NumericText? PAN { get; init; }

    /// <summary>
    /// Identify a card or a payment token inside a set of cards with the same PAN.
    /// </summary>
    [IsoId("_q77Yc4p3EeS3NqNpgnMh2w")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date from which the card can be used, expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_q77YdYp3EeS3NqNpgnMh2w")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_q77Yd4p3EeS3NqNpgnMh2w")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ExpiryDate { get; init; }

    /// <summary>
    /// Track number 1 from magnetic stripe card.
    /// </summary>
    [IsoId("_q77Ye4p3EeS3NqNpgnMh2w")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Track1 { get; init; }

    /// <summary>
    /// Track number 2 without control characters (start /end and LRC).
    /// </summary>
    [IsoId("_VPch4OmCEeSYo5PXsuJwzw")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck2")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Track2 { get; init; }

    /// <summary>
    /// Track number 3 from magnetic stripe card.
    /// </summary>
    [IsoId("_q77Yf4p3EeS3NqNpgnMh2w")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Track3 { get; init; }
}
