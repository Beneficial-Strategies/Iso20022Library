// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reporting of position or transaction for trade lifecycle events.
    /// </summary>
    [KnownType(typeof(TradeData57Choice.DataSetAction))]
    [KnownType(typeof(TradeData57Choice.Report))]
    [JsonDerivedType(
        typeof(TradeData57Choice.DataSetAction),
        nameof(TradeData57Choice.DataSetAction)
    )]
    [JsonDerivedType(typeof(TradeData57Choice.Report), nameof(TradeData57Choice.Report))]
    [IsoId("_xXUb4WEUEe2P-L9DBerEgA")]
    [DisplayName("Trade Data 57 Choice")]
    public abstract record TradeData57Choice_ { }
}
