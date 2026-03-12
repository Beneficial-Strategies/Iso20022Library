// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References42Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References42Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References42Choice.PoolIdentification))]
    [KnownType(typeof(References42Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References42Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(typeof(References42Choice.AccountOwnerTransactionIdentification),nameof(References42Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References42Choice.AccountServicerTransactionIdentification),nameof(References42Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References42Choice.PoolIdentification),nameof(References42Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References42Choice.MarketInfrastructureTransactionIdentification),nameof(References42Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References42Choice.ProcessorTransactionIdentification),nameof(References42Choice.ProcessorTransactionIdentification))]
    [IsoId("_FlUvwTp-EeWVrPy0StzzSg")]
    [DisplayName("References 42 Choice")]
    public abstract partial record References42Choice_
    {
    }
}
