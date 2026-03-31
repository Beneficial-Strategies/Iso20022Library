// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction Quantities4Choice.
    /// </summary>
    [KnownType(typeof(TransactionQuantities4Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(TransactionQuantities4Choice.Proprietary))]
    [KnownType(typeof(TransactionQuantities4Choice.Quantity))]
    [JsonDerivedType(
        typeof(TransactionQuantities4Choice.OriginalAndCurrentFaceAmount),
        nameof(TransactionQuantities4Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(
        typeof(TransactionQuantities4Choice.Proprietary),
        nameof(TransactionQuantities4Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(TransactionQuantities4Choice.Quantity),
        nameof(TransactionQuantities4Choice.Quantity)
    )]
    [IsoId("_CFAMAT3qEe-thIfLZ94a1w")]
    [DisplayName("Transaction Quantities4Choice")]
    public abstract record TransactionQuantities4Choice_ { }
}
