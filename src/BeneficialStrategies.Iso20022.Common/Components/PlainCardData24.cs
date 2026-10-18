// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plain Card Data24.
/// </summary>
[IsoId("_0a7UYaayEe-s1ZClExRjdw")]
[DisplayName("Plain Card Data24")]
public record PlainCardData24
{
    /// <summary>
    /// PAN.
    /// </summary>
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    public Min8Max28NumericText? PAN { get; init; }

    /// <summary>
    /// Card Sequence Number.
    /// </summary>
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    public Min2Max3NumericText? CardSequenceNumber { get; init; }

    /// <summary>
    /// Effective Date.
    /// </summary>
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public Max10Text? EffectiveDate { get; init; }

    /// <summary>
    /// Expiry Date.
    /// </summary>
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public Max10DateText? ExpiryDate { get; init; }

    /// <summary>
    /// Track1.
    /// </summary>
    [DisplayName("Track1")]
    [IsoXmlTag("Trck1")]
    public Max76Text? Track1 { get; init; }

    /// <summary>
    /// Track2.
    /// </summary>
    [DisplayName("Track2")]
    [IsoXmlTag("Trck2")]
    public Max37Text? Track2 { get; init; }

    /// <summary>
    /// Track3.
    /// </summary>
    [DisplayName("Track3")]
    [IsoXmlTag("Trck3")]
    public Max104Text? Track3 { get; init; }
}
