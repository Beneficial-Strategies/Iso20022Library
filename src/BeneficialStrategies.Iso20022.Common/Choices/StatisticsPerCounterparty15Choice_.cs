// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty15Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty15Choice.Report))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty15Choice.DataSetAction),nameof(StatisticsPerCounterparty15Choice.DataSetAction))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty15Choice.Report),nameof(StatisticsPerCounterparty15Choice.Report))]
    [IsoId("_cDvmkVovEe23K4GXSpBSeg")]
    [DisplayName("Statistics Per Counterparty 15 Choice")]
    public abstract partial record StatisticsPerCounterparty15Choice_
    {
    }
}
