// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References75Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References75Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References75Choice.PoolIdentification))]
    [KnownType(typeof(References75Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(
        typeof(References75Choice.CounterpartyMarketInfrastructureTransactionIdentification)
    )]
    [KnownType(typeof(References75Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(
        typeof(References75Choice.AccountOwnerTransactionIdentification),
        nameof(References75Choice.AccountOwnerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References75Choice.AccountServicerTransactionIdentification),
        nameof(References75Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References75Choice.PoolIdentification),
        nameof(References75Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References75Choice.MarketInfrastructureTransactionIdentification),
        nameof(References75Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References75Choice.CounterpartyMarketInfrastructureTransactionIdentification),
        nameof(References75Choice.CounterpartyMarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References75Choice.ProcessorTransactionIdentification),
        nameof(References75Choice.ProcessorTransactionIdentification)
    )]
    [IsoId("_ccpnozi8Eeydid5dcNPKvg")]
    [DisplayName("References 75 Choice")]
    public abstract record References75Choice_ { }
}
