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
[IsoId("_2Gul8S9mEeOlZIh7PImd0A")]
[DisplayName("Plain Card Data")]
public record PlainCardData4
{
    /// <summary>
    /// Primary Account Number (PAN) of the card, or card number.
    /// </summary>
    [IsoId("_2XsaIS9mEeOlZIh7PImd0A")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public required IsoMin8Max28NumericText PAN { get; init; }

    /// <summary>
    /// Identify a card inside a set of cards with the same card number (PAN).
    /// </summary>
    [IsoId("_2XsaIy9mEeOlZIh7PImd0A")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date from which the card can be used, expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_2XsaJS9mEeOlZIh7PImd0A")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_2XsaJy9mEeOlZIh7PImd0A")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public required IsoMax10Text ExpiryDate { get; init; }

    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [IsoId("_2XsaKS9mEeOlZIh7PImd0A")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// Magnetic track or equivalent payment card data.
    /// </summary>
    [IsoId("_2XsaKy9mEeOlZIh7PImd0A")]
    [DisplayName("Track Data")]
    [IsoXmlTag("TrckData")]
    public ValueList<TrackData1> TrackData { get; init; } = [];

    /// <summary>
    /// Card security code (CSC) associated with the card performing the transaction.
    /// </summary>
    [IsoId("_2XsaLS9mEeOlZIh7PImd0A")]
    [DisplayName("Card Security Code")]
    [IsoXmlTag("CardSctyCd")]
    public CardSecurityInformation1? CardSecurityCode { get; init; }
}
