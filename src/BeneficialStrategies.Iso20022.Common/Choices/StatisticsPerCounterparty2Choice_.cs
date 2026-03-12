// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Statistics per counterparty reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(StatisticsPerCounterparty2Choice.DataSetAction))]
    [KnownType(typeof(StatisticsPerCounterparty2Choice.Report))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty2Choice.DataSetAction),nameof(StatisticsPerCounterparty2Choice.DataSetAction))]
    [JsonDerivedType(typeof(StatisticsPerCounterparty2Choice.Report),nameof(StatisticsPerCounterparty2Choice.Report))]
    [IsoId("_85s8k0wWEeqwfMIOLcNxbw")]
    [DisplayName("Statistics Per Counterparty 2 Choice")]
    public abstract partial record StatisticsPerCounterparty2Choice_
    {
    }
}
