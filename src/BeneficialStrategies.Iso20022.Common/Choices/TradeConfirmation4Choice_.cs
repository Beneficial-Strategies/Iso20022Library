// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Confirmation4Choice.
    /// </summary>
    [KnownType(typeof(TradeConfirmation4Choice.Confirmed))]
    [KnownType(typeof(TradeConfirmation4Choice.NonConfirmed))]
    [JsonDerivedType(
        typeof(TradeConfirmation4Choice.Confirmed),
        nameof(TradeConfirmation4Choice.Confirmed)
    )]
    [JsonDerivedType(
        typeof(TradeConfirmation4Choice.NonConfirmed),
        nameof(TradeConfirmation4Choice.NonConfirmed)
    )]
    [IsoId("_-DShYY-SEe6Ojt1b3tfu9Q")]
    [DisplayName("Trade Confirmation4Choice")]
    public abstract record TradeConfirmation4Choice_ { }
}
