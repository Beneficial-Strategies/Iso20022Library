// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData15Choice.DataSetAction))]
    [KnownType(typeof(TradeData15Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData15Choice.DataSetAction),
        nameof(TradeData15Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData15Choice.Report), nameof(TradeData15Choice.Report))]
    [IsoId("_30uHkf_qEemm3skPVSMJQg")]
    [DisplayName("Trade Data 15 Choice")]
    public abstract record TradeData15Choice_ { }
}
