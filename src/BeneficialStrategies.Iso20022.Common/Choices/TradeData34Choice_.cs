// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData34Choice.DataSetAction))]
    [KnownType(typeof(TradeData34Choice.Report))]
    [JsonDerivedType(typeof(TradeData34Choice.DataSetAction),nameof(TradeData34Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData34Choice.Report),nameof(TradeData34Choice.Report))]
    [IsoId("_Ap4T0cK3EeuFNp8LZAnorg")]
    [DisplayName("Trade Data 34 Choice")]
    public abstract partial record TradeData34Choice_
    {
    }
}
