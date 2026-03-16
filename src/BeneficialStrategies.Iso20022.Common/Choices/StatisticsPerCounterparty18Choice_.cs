// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics Per Counterparty18Choice.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty18Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty18Choice.Report))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty18Choice.DataSetAction),nameof(StatisticsPerCounterparty18Choice.DataSetAction))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty18Choice.Report),nameof(StatisticsPerCounterparty18Choice.Report))]
    [IsoId("_l0kjsfreEe2mU4Wi2q3MzQ")]
    [DisplayName("Statistics Per Counterparty18Choice")]
    public abstract partial record StatisticsPerCounterparty18Choice_
    {
    }
}
