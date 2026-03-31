// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plain Card Data25.
/// </summary>
[IsoId("_EUbjsaazEe-s1ZClExRjdw")]
[DisplayName("Plain Card Data25")]
public record PlainCardData25
{
    /// <summary>
    /// Cardholder Name.
    /// </summary>
    [DisplayName("Cardholder Name")]
    [IsoXmlTag("CrdhldrNm")]
    public IsoMax45Text? CardholderName { get; init; }

    /// <summary>
    /// Card Sequence Number.
    /// </summary>
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Effective Date.
    /// </summary>
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public IsoMax10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public IsoMax10DateText? ExpiryDate { get; init; }

    /// <summary>
    /// PAN.
    /// </summary>
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    public IsoMin8Max28NumericText? PAN { get; init; }

    /// <summary>
    /// Service Code.
    /// </summary>
    [DisplayName("Service Code")]
    [IsoXmlTag("SvcCd")]
    public IsoExact3NumericText? ServiceCode { get; init; }

    /// <summary>
    /// Track1.
    /// </summary>
    [DisplayName("Track1")]
    [IsoXmlTag("Trck1")]
    public IsoMax76Text? Track1 { get; init; }

    /// <summary>
    /// Track2.
    /// </summary>
    [DisplayName("Track2")]
    [IsoXmlTag("Trck2")]
    public IsoMax37Text? Track2 { get; init; }

    /// <summary>
    /// Track3.
    /// </summary>
    [DisplayName("Track3")]
    [IsoXmlTag("Trck3")]
    public IsoMax104Text? Track3 { get; init; }
}
