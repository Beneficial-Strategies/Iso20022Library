// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References27Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References27Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References27Choice.PoolIdentification))]
    [KnownType(typeof(References27Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References27Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(
        typeof(References27Choice.AccountOwnerTransactionIdentification),
        nameof(References27Choice.AccountOwnerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References27Choice.AccountServicerTransactionIdentification),
        nameof(References27Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References27Choice.PoolIdentification),
        nameof(References27Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References27Choice.MarketInfrastructureTransactionIdentification),
        nameof(References27Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References27Choice.ProcessorTransactionIdentification),
        nameof(References27Choice.ProcessorTransactionIdentification)
    )]
    [IsoId("_mKkkp_7xEeCvPoRGOxRobQ")]
    [DisplayName("References 27 Choice")]
    public abstract record References27Choice_ { }
}
