// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// References80Choice.
    /// </summary>
    [KnownType(typeof(References80Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References80Choice.CommonIdentification))]
    [KnownType(
        typeof(References80Choice.CounterpartyMarketInfrastructureTransactionIdentification)
    )]
    [KnownType(typeof(References80Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References80Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References80Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References80Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References80Choice.PoolIdentification))]
    [KnownType(typeof(References80Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References80Choice.TradeIdentification))]
    [KnownType(typeof(References80Choice.UniqueTransactionIdentifier))]
    [JsonDerivedType(
        typeof(References80Choice.AccountServicerTransactionIdentification),
        nameof(References80Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.CommonIdentification),
        nameof(References80Choice.CommonIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.CounterpartyMarketInfrastructureTransactionIdentification),
        nameof(References80Choice.CounterpartyMarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.IntraBalanceMovementIdentification),
        nameof(References80Choice.IntraBalanceMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.IntraPositionMovementIdentification),
        nameof(References80Choice.IntraPositionMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.MarketInfrastructureTransactionIdentification),
        nameof(References80Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.OtherTransactionIdentification),
        nameof(References80Choice.OtherTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.PoolIdentification),
        nameof(References80Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References80Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.TradeIdentification),
        nameof(References80Choice.TradeIdentification)
    )]
    [JsonDerivedType(
        typeof(References80Choice.UniqueTransactionIdentifier),
        nameof(References80Choice.UniqueTransactionIdentifier)
    )]
    [IsoId("_gLk2a4YdEe-Pv9KR9bv9IA")]
    [DisplayName("References80Choice")]
    public abstract record References80Choice_ { }
}
