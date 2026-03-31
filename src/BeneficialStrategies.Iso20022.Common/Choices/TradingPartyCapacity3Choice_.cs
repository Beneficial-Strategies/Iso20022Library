// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading capacity.
    /// </summary>
    [KnownType(typeof(TradingPartyCapacity3Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradingPartyCapacity3Choice.Code),
        nameof(TradingPartyCapacity3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradingPartyCapacity3Choice.Proprietary),
        nameof(TradingPartyCapacity3Choice.Proprietary)
    )]
    [IsoId("_YLdZIY-1Eeaoj_JbcpWKgg")]
    [DisplayName("Trading Party Capacity 3 Choice")]
    public abstract record TradingPartyCapacity3Choice_ { }
}
