// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References51Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References51Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References51Choice.PoolIdentification))]
    [KnownType(typeof(References51Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References51Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(
        typeof(References51Choice.AccountOwnerTransactionIdentification),
        nameof(References51Choice.AccountOwnerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References51Choice.AccountServicerTransactionIdentification),
        nameof(References51Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References51Choice.PoolIdentification),
        nameof(References51Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References51Choice.MarketInfrastructureTransactionIdentification),
        nameof(References51Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References51Choice.ProcessorTransactionIdentification),
        nameof(References51Choice.ProcessorTransactionIdentification)
    )]
    [IsoId("_5Qz08ZNLEeWGlc8L7oPDIg")]
    [DisplayName("References 51 Choice")]
    public abstract record References51Choice_ { }
}
