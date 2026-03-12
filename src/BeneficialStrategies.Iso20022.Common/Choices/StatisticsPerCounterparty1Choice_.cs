// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty1Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty1Choice.Report))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty1Choice.DataSetAction),nameof(StatisticsPerCounterparty1Choice.DataSetAction))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty1Choice.Report),nameof(StatisticsPerCounterparty1Choice.Report))]
    [IsoId("_98o1tEwVEeqwfMIOLcNxbw")]
    [DisplayName("Statistics Per Counterparty 1 Choice")]
    public abstract partial record StatisticsPerCounterparty1Choice_
    {
    }
}
