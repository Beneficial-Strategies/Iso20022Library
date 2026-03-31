// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData13Choice.DataSetAction))]
    [KnownType(typeof(TradeData13Choice.State))]
    [JsonDerivedType(
        typeof(TradeData13Choice.DataSetAction),
        nameof(TradeData13Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData13Choice.State), nameof(TradeData13Choice.State))]
    [IsoId("_xzjzMf_mEemm3skPVSMJQg")]
    [DisplayName("Trade Data 13 Choice")]
    public abstract record TradeData13Choice_ { }
}
