// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData6Choice.DataSetAction))]
    [KnownType(typeof(TradeData6Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData6Choice.DataSetAction),
        nameof(TradeData6Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData6Choice.Report), nameof(TradeData6Choice.Report))]
    [IsoId("_Mg2fIa07EemojPqsRBB5Lg")]
    [DisplayName("Trade Data 6 Choice")]
    public abstract record TradeData6Choice_ { }
}
