// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty16Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty16Choice.Report))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty16Choice.DataSetAction),nameof(StatisticsPerCounterparty16Choice.DataSetAction))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty16Choice.Report),nameof(StatisticsPerCounterparty16Choice.Report))]
    [IsoId("_robnAVowEe23K4GXSpBSeg")]
    [DisplayName("Statistics Per Counterparty 16 Choice")]
    public abstract partial record StatisticsPerCounterparty16Choice_
    {
    }
}
