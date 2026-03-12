// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData37Choice.DataSetAction))]
    [KnownType(typeof(TradeData37Choice.State))]
    [JsonDerivedType(typeof(TradeData37Choice.DataSetAction),nameof(TradeData37Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData37Choice.State),nameof(TradeData37Choice.State))]
    [IsoId("_SzR6ccK9EeuCIrYISEfoUg")]
    [DisplayName("Trade Data 37 Choice")]
    public abstract partial record TradeData37Choice_
    {
    }
}
