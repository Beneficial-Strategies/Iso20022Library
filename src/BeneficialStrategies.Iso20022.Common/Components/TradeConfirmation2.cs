// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies time and type of contract confirmation.
/// </summary>
[IsoId("_8KV5lA27EeWmAKKPnqYEVQ")]
[DisplayName("Trade Confirmation")]
public record TradeConfirmation2
{
    /// <summary>
    /// Specifies whether the contract was confirmed electronically or non-electronically.
    /// </summary>
    [IsoId("_8KV5lg27EeWmAKKPnqYEVQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TradeConfirmationType1Code Type { get; init; }

    /// <summary>
    /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
    /// </summary>
    [IsoId("_8KV5lQ27EeWmAKKPnqYEVQ")]
    [DisplayName("Time Stamp")]
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TimeStamp { get; init; }
}
