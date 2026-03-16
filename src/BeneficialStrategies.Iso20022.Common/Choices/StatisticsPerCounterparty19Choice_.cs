// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics Per Counterparty19Choice.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty19Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty19Choice.Report))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty19Choice.DataSetAction),nameof(StatisticsPerCounterparty19Choice.DataSetAction))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty19Choice.Report),nameof(StatisticsPerCounterparty19Choice.Report))]
    [IsoId("_BSmTwZBIEe6Ojt1b3tfu9Q")]
    [DisplayName("Statistics Per Counterparty19Choice")]
    public abstract partial record StatisticsPerCounterparty19Choice_
    {
    }
}
