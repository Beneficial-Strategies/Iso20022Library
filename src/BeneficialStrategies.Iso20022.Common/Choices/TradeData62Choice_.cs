// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade Data62Choice.
    /// </summary>
    [KnownType(typeof(TradeData62Choice.DataSetAction))]
    [KnownType(typeof(TradeData62Choice.State))]
    [JsonDerivedType(
        typeof(TradeData62Choice.DataSetAction),
        nameof(TradeData62Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData62Choice.State), nameof(TradeData62Choice.State))]
    [IsoId("_hnh6EcEkEe66laxnCpxfpw")]
    [DisplayName("Trade Data62Choice")]
    public abstract record TradeData62Choice_ { }
}
