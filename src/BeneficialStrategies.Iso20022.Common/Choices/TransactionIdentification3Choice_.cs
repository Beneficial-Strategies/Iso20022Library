// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [KnownType(typeof(TransactionIdentification3Choice.Transaction))]
    [KnownType(typeof(TransactionIdentification3Choice.MarginReporting))]
    [KnownType(typeof(TransactionIdentification3Choice.CollateralReuse))]
    [JsonDerivedType(
        typeof(TransactionIdentification3Choice.Transaction),
        nameof(TransactionIdentification3Choice.Transaction)
    )]
    [JsonDerivedType(
        typeof(TransactionIdentification3Choice.MarginReporting),
        nameof(TransactionIdentification3Choice.MarginReporting)
    )]
    [JsonDerivedType(
        typeof(TransactionIdentification3Choice.CollateralReuse),
        nameof(TransactionIdentification3Choice.CollateralReuse)
    )]
    [IsoId("_hXhZR8K4EeuFNp8LZAnorg")]
    [DisplayName("Transaction Identification 3 Choice")]
    public abstract record TransactionIdentification3Choice_ { }
}
