// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References19Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References19Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References19Choice.PoolIdentification))]
    [KnownType(typeof(References19Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References19Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(
        typeof(References19Choice.AccountOwnerTransactionIdentification),
        nameof(References19Choice.AccountOwnerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References19Choice.AccountServicerTransactionIdentification),
        nameof(References19Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References19Choice.PoolIdentification),
        nameof(References19Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References19Choice.MarketInfrastructureTransactionIdentification),
        nameof(References19Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References19Choice.ProcessorTransactionIdentification),
        nameof(References19Choice.ProcessorTransactionIdentification)
    )]
    [IsoId("_w7exzUADEeC4mKrqv7wPJQ")]
    [DisplayName("References 19 Choice")]
    public abstract record References19Choice_ { }
}
