// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading capacity.
    /// </summary>
    [KnownType(typeof(TradingPartyCapacity4Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradingPartyCapacity4Choice.Code),
        nameof(TradingPartyCapacity4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradingPartyCapacity4Choice.Proprietary),
        nameof(TradingPartyCapacity4Choice.Proprietary)
    )]
    [IsoId("_HcLafZBjEeakHoV5BVecAQ")]
    [DisplayName("Trading Party Capacity 4 Choice")]
    public abstract record TradingPartyCapacity4Choice_ { }
}
