// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading capacity of the party.
    /// </summary>
    [KnownType(typeof(TradeOriginator3Choice.Code))]
    [KnownType(typeof(TradeOriginator3Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeOriginator3Choice.Code),nameof(TradeOriginator3Choice.Code))]
    [JsonDerivedType(typeof(TradeOriginator3Choice.Proprietary),nameof(TradeOriginator3Choice.Proprietary))]
    [IsoId("_6bs6cTtCEeWRTLSN0i0tng")]
    [DisplayName("Trade Originator 3 Choice")]
    public abstract partial record TradeOriginator3Choice_
    {
    }
}
