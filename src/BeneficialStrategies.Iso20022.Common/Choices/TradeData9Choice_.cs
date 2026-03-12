// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data concerning the reporting trade.
    /// </summary>
    [KnownType(typeof(TradeData9Choice.DataSetAction))]
    [KnownType(typeof(TradeData9Choice.Report))]
    [JsonDerivedType(typeof(TradeData9Choice.DataSetAction),nameof(TradeData9Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData9Choice.Report),nameof(TradeData9Choice.Report))]
    [IsoId("_zLimQa1GEemojPqsRBB5Lg")]
    [DisplayName("Trade Data 9 Choice")]
    public abstract partial record TradeData9Choice_
    {
    }
}
