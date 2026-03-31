// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty17Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty17Choice.Report))]
    [JsonDerivedType(
        typeof(StatisticsPerCounterparty17Choice.DataSetAction),
        nameof(StatisticsPerCounterparty17Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(StatisticsPerCounterparty17Choice.Report),
        nameof(StatisticsPerCounterparty17Choice.Report)
    )]
    [IsoId("_x7sJF1yGEe24CqbZJK5XxA")]
    [DisplayName("Statistics Per Counterparty 17 Choice")]
    public abstract record StatisticsPerCounterparty17Choice_ { }
}
