// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References5Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References5Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References5Choice.PoolIdentification))]
    [KnownType(typeof(References5Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(
        typeof(References5Choice.AccountOwnerTransactionIdentification),
        nameof(References5Choice.AccountOwnerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References5Choice.AccountServicerTransactionIdentification),
        nameof(References5Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References5Choice.PoolIdentification),
        nameof(References5Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References5Choice.MarketInfrastructureTransactionIdentification),
        nameof(References5Choice.MarketInfrastructureTransactionIdentification)
    )]
    [IsoId("_USg8Htp-Ed-ak6NoX_4Aeg_-283590354")]
    [DisplayName("References 5 Choice")]
    public abstract record References5Choice_ { }
}
