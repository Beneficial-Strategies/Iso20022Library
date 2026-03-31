// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the quantities (such as securities) in the underlying transaction.
    /// </summary>
    [KnownType(typeof(TransactionQuantities3Choice.Quantity))]
    [KnownType(typeof(TransactionQuantities3Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(TransactionQuantities3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TransactionQuantities3Choice.Quantity),
        nameof(TransactionQuantities3Choice.Quantity)
    )]
    [JsonDerivedType(
        typeof(TransactionQuantities3Choice.OriginalAndCurrentFaceAmount),
        nameof(TransactionQuantities3Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(
        typeof(TransactionQuantities3Choice.Proprietary),
        nameof(TransactionQuantities3Choice.Proprietary)
    )]
    [IsoId("_dBfEgXkcEei6JsZKrqN0hQ")]
    [DisplayName("Transaction Quantities 3 Choice")]
    public abstract record TransactionQuantities3Choice_ { }
}
