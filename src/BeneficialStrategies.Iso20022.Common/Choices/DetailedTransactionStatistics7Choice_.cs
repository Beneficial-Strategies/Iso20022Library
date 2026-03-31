// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Detailed Transaction Statistics7Choice.
    /// </summary>
    [KnownType(typeof(DetailedTransactionStatistics7Choice.DataSetAction))]
    [KnownType(typeof(DetailedTransactionStatistics7Choice.DetailedStatistics))]
    [JsonDerivedType(
        typeof(DetailedTransactionStatistics7Choice.DataSetAction),
        nameof(DetailedTransactionStatistics7Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(DetailedTransactionStatistics7Choice.DetailedStatistics),
        nameof(DetailedTransactionStatistics7Choice.DetailedStatistics)
    )]
    [IsoId("_l6YQx_reEe2mU4Wi2q3MzQ")]
    [DisplayName("Detailed Transaction Statistics7Choice")]
    public abstract record DetailedTransactionStatistics7Choice_ { }
}
