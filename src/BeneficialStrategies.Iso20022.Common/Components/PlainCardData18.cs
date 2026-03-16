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
[IsoId("_uieA4a14EeWMg5rOByfExw")]
[DisplayName("Plain Card Data")]
public record PlainCardData18
{
    /// <summary>
    /// Primary Account Number (PAN) of the card.
    /// </summary>
    [IsoId("_uuiG8a14EeWMg5rOByfExw")]
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
    public IsoMin8Max28NumericText? PAN { get; init; }

    /// <summary>
    /// Identify a card or a payment token inside a set of cards with the same PAN.
    /// </summary>
    [IsoId("_uuiG8614EeWMg5rOByfExw")]
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Date from which the card can be used, expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_uuiG9a14EeWMg5rOByfExw")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry date of the card expressed either in the YYYY-MM format, or in the YYYY-MM-DD format.
    /// </summary>
    [IsoId("_uuiG9614EeWMg5rOByfExw")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10, MinimumLength = 1)]
    public IsoMax10Text? ExpiryDate { get; init; }

    /// <summary>
    /// Services attached to the card, as defined in ISO 7813.
    /// </summary>
    [IsoId("_uuiG-a14EeWMg5rOByfExw")]
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// ISO track 1 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The format is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_uuiG-614EeWMg5rOByfExw")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck1")]
    [IsoSimpleType(IsoSimpleType.Max76Text)]
    [StringLength(maximumLength: 76, MinimumLength = 1)]
    public IsoMax76Text? Track1 { get; init; }

    /// <summary>
    /// ISO track 2 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 7813, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_uuiG_a14EeWMg5rOByfExw")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck2")]
    [IsoSimpleType(IsoSimpleType.Max37Text)]
    [StringLength(maximumLength: 37, MinimumLength = 1)]
    public IsoMax37Text? Track2 { get; init; }

    /// <summary>
    /// ISO track 3 issued from the magnetic stripe card or from the ICC if the magnetic stripe was not read. The content is conform to ISO 4909, removing beginning and ending sentinels and longitudinal redundancy check characters.
    /// </summary>
    [IsoId("_uuiG_614EeWMg5rOByfExw")]
    [DisplayName("Track")]
    [IsoXmlTag("Trck3")]
    [IsoSimpleType(IsoSimpleType.Max104Text)]
    [StringLength(maximumLength: 104, MinimumLength = 1)]
    public IsoMax104Text? Track3 { get; init; }

    /// <summary>
    /// Name of the cardholder stored on the card.
    /// </summary>
    [IsoId("_uuiHAa14EeWMg5rOByfExw")]
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45, MinimumLength = 1)]
    public IsoMax45Text? CardholderName { get; init; }
}
