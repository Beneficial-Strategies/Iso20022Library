// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details for a trade state report.
    /// </summary>
    [KnownType(typeof(TradeStateReport2Choice.DataSetAction))]
    [KnownType(typeof(TradeStateReport2Choice.State))]
    [JsonDerivedType(
        typeof(TradeStateReport2Choice.DataSetAction),
        nameof(TradeStateReport2Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeStateReport2Choice.State), nameof(TradeStateReport2Choice.State))]
    [IsoId("_e9vysQAFEeqefbt-QjTNnA")]
    [DisplayName("Trade State Report 2 Choice")]
    public abstract record TradeStateReport2Choice_ { }
}
