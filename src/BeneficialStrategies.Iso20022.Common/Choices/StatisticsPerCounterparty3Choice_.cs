// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty3Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty3Choice.Report))]
    [JsonDerivedType(
        typeof(StatisticsPerCounterparty3Choice.DataSetAction),
        nameof(StatisticsPerCounterparty3Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(StatisticsPerCounterparty3Choice.Report),
        nameof(StatisticsPerCounterparty3Choice.Report)
    )]
    [IsoId("_66pN4c2GEeqFGLkKbAvCGg")]
    [DisplayName("Statistics Per Counterparty 3 Choice")]
    public abstract record StatisticsPerCounterparty3Choice_ { }
}
