// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Detailed information of no valuation or outdated valuation.
    /// </summary>
    [KnownType(typeof(DetailedMissingValuationsStatistics4Choice.DataSetAction))]
    [KnownType(typeof(DetailedMissingValuationsStatistics4Choice.Report))]
    [JsonDerivedType(typeof(DetailedMissingValuationsStatistics4Choice.DataSetAction),nameof(DetailedMissingValuationsStatistics4Choice.DataSetAction))]
    [JsonDerivedType(typeof(DetailedMissingValuationsStatistics4Choice.Report),nameof(DetailedMissingValuationsStatistics4Choice.Report))]
    [IsoId("_x0O2MVyGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Missing Valuations Statistics 4 Choice")]
    public abstract partial record DetailedMissingValuationsStatistics4Choice_
    {
    }
}
