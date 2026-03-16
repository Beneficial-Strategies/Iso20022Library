// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details for a trade state report.
    /// </summary>
    [KnownType(typeof(TradeStateReport5Choice.DataSetAction))]
    [KnownType(typeof(TradeStateReport5Choice.State))]
    [JsonDerivedType(
        typeof(TradeStateReport5Choice.DataSetAction),
        nameof(TradeStateReport5Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeStateReport5Choice.State), nameof(TradeStateReport5Choice.State))]
    [IsoId("_x9GcscK-EeuCIrYISEfoUg")]
    [DisplayName("Trade State Report 5 Choice")]
    public abstract record TradeStateReport5Choice_ { }
}
