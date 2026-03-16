// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// References81Choice.
    /// </summary>
    [KnownType(typeof(References81Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References81Choice.CommonIdentification))]
    [KnownType(typeof(References81Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References81Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References81Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References81Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References81Choice.OtherTransactionIdentification))]
    [KnownType(typeof(References81Choice.PoolIdentification))]
    [KnownType(typeof(References81Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References81Choice.TradeIdentification))]
    [KnownType(typeof(References81Choice.UniqueTransactionIdentifier))]
    [JsonDerivedType(typeof(References81Choice.AccountServicerTransactionIdentification),nameof(References81Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References81Choice.CommonIdentification),nameof(References81Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References81Choice.CounterpartyMarketInfrastructureTransactionIdentification),nameof(References81Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References81Choice.IntraBalanceMovementIdentification),nameof(References81Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References81Choice.IntraPositionMovementIdentification),nameof(References81Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References81Choice.MarketInfrastructureTransactionIdentification),nameof(References81Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References81Choice.OtherTransactionIdentification),nameof(References81Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References81Choice.PoolIdentification),nameof(References81Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References81Choice.SecuritiesSettlementTransactionIdentification),nameof(References81Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References81Choice.TradeIdentification),nameof(References81Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References81Choice.UniqueTransactionIdentifier),nameof(References81Choice.UniqueTransactionIdentifier))]
    [IsoId("_Nn_J-4YeEe-Pv9KR9bv9IA")]
    [DisplayName("References81Choice")]
    public abstract partial record References81Choice_
    {
    }
}
