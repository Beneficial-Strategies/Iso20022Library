// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData55Choice.DataSetAction))]
    [KnownType(typeof(TradeData55Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData55Choice.DataSetAction),
        nameof(TradeData55Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData55Choice.Report), nameof(TradeData55Choice.Report))]
    [IsoId("_ovXE8VosEe23K4GXSpBSeg")]
    [DisplayName("Trade Data 55 Choice")]
    public abstract record TradeData55Choice_ { }
}
