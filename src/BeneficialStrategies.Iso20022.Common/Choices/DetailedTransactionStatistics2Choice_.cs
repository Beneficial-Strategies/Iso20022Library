// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about number of transactions accepted and rejected and the reasons of the rejections.
    /// </summary>
    [KnownType(typeof(DetailedTransactionStatistics2Choice.DataSetAction))]
    [KnownType(typeof(DetailedTransactionStatistics2Choice.DetailedStatistics))]
    [JsonDerivedType(
        typeof(DetailedTransactionStatistics2Choice.DataSetAction),
        nameof(DetailedTransactionStatistics2Choice.DataSetAction)
    )]
    [JsonDerivedType(
        typeof(DetailedTransactionStatistics2Choice.DetailedStatistics),
        nameof(DetailedTransactionStatistics2Choice.DetailedStatistics)
    )]
    [IsoId("_hTXSB8K4EeuFNp8LZAnorg")]
    [DisplayName("Detailed Transaction Statistics 2 Choice")]
    public abstract record DetailedTransactionStatistics2Choice_ { }
}
