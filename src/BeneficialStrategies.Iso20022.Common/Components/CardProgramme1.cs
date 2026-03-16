// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card programme or brand related to the transaction.
/// </summary>
[IsoId("_mv6NAEX_Eeegp_DADCe7HQ")]
[DisplayName("Card Programme")]
public record CardProgramme1
{
    /// <summary>
    /// Card programme or brand proposed for the transaction.
    /// </summary>
    [IsoId("_0uj5MEX_Eeegp_DADCe7HQ")]
    [DisplayName("Card Programme Proposed")]
    [IsoXmlTag("CardPrgrmmPropsd")]
    public CardProgrammeMode2? CardProgrammeProposed { get; init; }

    /// <summary>
    /// Card programme or brand actually applied to the transaction.
    /// ISO 8583:87 bit 24
    /// </summary>
    [IsoId("_7xBZ4EYAEeegp_DADCe7HQ")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public CardProgrammeMode1? CardProgrammeApplied { get; init; }
}
