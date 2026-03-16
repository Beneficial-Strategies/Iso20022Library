// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading capacity.
    /// </summary>
    [KnownType(typeof(TradingPartyCapacity1Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradingPartyCapacity1Choice.Code),
        nameof(TradingPartyCapacity1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradingPartyCapacity1Choice.Proprietary),
        nameof(TradingPartyCapacity1Choice.Proprietary)
    )]
    [IsoId("_AXUwVNokEeC60axPepSq7g_2103610848")]
    [DisplayName("Trading Party Capacity 1 Choice")]
    public abstract record TradingPartyCapacity1Choice_ { }
}
