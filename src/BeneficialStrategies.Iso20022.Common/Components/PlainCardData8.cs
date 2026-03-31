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
[IsoId("_WO-mMWkjEeSTIuB9A-QJ6g")]
[DisplayName("Plain Card Data")]
public record PlainCardData8
{
    /// <summary>
    /// Primary Account Number (PAN) of the card, or surrogate of the PAN by a payment token.
    /// </summary>
    [IsoId("_WcCx0WkjEeSTIuB9A-QJ6g")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public required IsoMin8Max28NumericText PAN { get; init; }

    /// <summary>
    /// Identify a card or a payment token inside a set of cards with the same PAN or token.
    /// </summary>
    [IsoId("_WcCx02kjEeSTIuB9A-QJ6g")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date as from which the card can be used.
    /// </summary>
    [IsoId("_WcCx1WkjEeSTIuB9A-QJ6g")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card or the payment token expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_WcCx12kjEeSTIuB9A-QJ6g")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public required IsoMax10Text ExpiryDate { get; init; }
}
