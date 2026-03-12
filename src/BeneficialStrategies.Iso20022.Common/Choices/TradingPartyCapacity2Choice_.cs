// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading capacity.
    /// </summary>
    [KnownType(typeof(TradingPartyCapacity2Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity2Choice.Proprietary))]
    [JsonDerivedType(typeof(TradingPartyCapacity2Choice.Code),nameof(TradingPartyCapacity2Choice.Code))]
    [JsonDerivedType(typeof(TradingPartyCapacity2Choice.Proprietary),nameof(TradingPartyCapacity2Choice.Proprietary))]
    [IsoId("_AXehUdokEeC60axPepSq7g_-114557953")]
    [DisplayName("Trading Party Capacity 2 Choice")]
    public abstract partial record TradingPartyCapacity2Choice_
    {
    }
}
