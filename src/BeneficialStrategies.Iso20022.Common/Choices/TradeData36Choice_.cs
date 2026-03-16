// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of data concerning the reporting trade..
    /// </summary>
    [KnownType(typeof(TradeData36Choice.DataSetAction))]
    [KnownType(typeof(TradeData36Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData36Choice.DataSetAction),
        nameof(TradeData36Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData36Choice.Report), nameof(TradeData36Choice.Report))]
    [IsoId("_MvN7scK8EeuMhqg3CsEu6Q")]
    [DisplayName("Trade Data 36 Choice")]
    public abstract record TradeData36Choice_ { }
}
