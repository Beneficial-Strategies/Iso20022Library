// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about number of transactions accepted and rejected and the reasons of the rejections.
    /// </summary>
    [KnownType(typeof(DetailedTransactionStatistics6Choice.DataSetAction))]
    [KnownType(typeof(DetailedTransactionStatistics6Choice.DetailedStatistics))]
    [JsonDerivedType(typeof(DetailedTransactionStatistics6Choice.DataSetAction),nameof(DetailedTransactionStatistics6Choice.DataSetAction))]
    [JsonDerivedType(typeof(DetailedTransactionStatistics6Choice.DetailedStatistics),nameof(DetailedTransactionStatistics6Choice.DetailedStatistics))]
    [IsoId("_x-ovZ1yGEe24CqbZJK5XxA")]
    [DisplayName("Detailed Transaction Statistics 6 Choice")]
    public abstract partial record DetailedTransactionStatistics6Choice_
    {
    }
}
