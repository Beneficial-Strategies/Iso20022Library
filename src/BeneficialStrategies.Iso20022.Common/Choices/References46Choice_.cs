// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References46Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References46Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References46Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References46Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References46Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References46Choice.PoolIdentification))]
    [KnownType(typeof(References46Choice.CommonIdentification))]
    [KnownType(typeof(References46Choice.TradeIdentification))]
    [KnownType(typeof(References46Choice.OtherTransactionIdentification))]
    [JsonDerivedType(
        typeof(References46Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References46Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.IntraPositionMovementIdentification),
        nameof(References46Choice.IntraPositionMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.IntraBalanceMovementIdentification),
        nameof(References46Choice.IntraBalanceMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.AccountServicerTransactionIdentification),
        nameof(References46Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.MarketInfrastructureTransactionIdentification),
        nameof(References46Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.PoolIdentification),
        nameof(References46Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.CommonIdentification),
        nameof(References46Choice.CommonIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.TradeIdentification),
        nameof(References46Choice.TradeIdentification)
    )]
    [JsonDerivedType(
        typeof(References46Choice.OtherTransactionIdentification),
        nameof(References46Choice.OtherTransactionIdentification)
    )]
    [IsoId("_1yo1ETt4EeW638lNyHKv7A")]
    [DisplayName("References 46 Choice")]
    public abstract record References46Choice_ { }
}
