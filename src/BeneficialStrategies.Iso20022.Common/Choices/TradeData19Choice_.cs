// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Position/transaction reporting under EMIR regulation.
    /// </summary>
    [KnownType(typeof(TradeData19Choice.DataSetAction))]
    [KnownType(typeof(TradeData19Choice.Report))]
    [KnownType(typeof(TradeData19Choice.State))]
    [JsonDerivedType(
        typeof(TradeData19Choice.DataSetAction),
        nameof(TradeData19Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData19Choice.Report), nameof(TradeData19Choice.Report))]
    [JsonDerivedType(typeof(TradeData19Choice.State), nameof(TradeData19Choice.State))]
    [IsoId("_mijCQXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Trade Data 19 Choice")]
    public abstract record TradeData19Choice_ { }
}
