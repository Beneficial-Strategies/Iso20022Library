// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Confirmation5.
/// </summary>
[IsoId("_DVBgwI-TEe6Ojt1b3tfu9Q")]
[DisplayName("Trade Confirmation5")]
public record TradeConfirmation5
{
    /// <summary>
    /// Time Stamp.
    /// </summary>
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    public IsoISODateTime? TimeStamp { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TradeConfirmationType1Code Type { get; init; }
}
