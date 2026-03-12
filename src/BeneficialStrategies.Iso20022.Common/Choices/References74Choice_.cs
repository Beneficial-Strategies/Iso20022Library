// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between references.
    /// </summary>
    [KnownType(typeof(References74Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References74Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References74Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References74Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References74Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References74Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References74Choice.PoolIdentification))]
    [KnownType(typeof(References74Choice.CommonIdentification))]
    [KnownType(typeof(References74Choice.TradeIdentification))]
    [KnownType(typeof(References74Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References74Choice.SecuritiesSettlementTransactionIdentification),nameof(References74Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References74Choice.IntraPositionMovementIdentification),nameof(References74Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References74Choice.IntraBalanceMovementIdentification),nameof(References74Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References74Choice.AccountServicerTransactionIdentification),nameof(References74Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References74Choice.MarketInfrastructureTransactionIdentification),nameof(References74Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References74Choice.CounterpartyMarketInfrastructureTransactionIdentification),nameof(References74Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References74Choice.PoolIdentification),nameof(References74Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References74Choice.CommonIdentification),nameof(References74Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References74Choice.TradeIdentification),nameof(References74Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References74Choice.OtherTransactionIdentification),nameof(References74Choice.OtherTransactionIdentification))]
    [IsoId("_SKsBTSgaEey2k_sfZmJz4g")]
    [DisplayName("References 74 Choice")]
    public abstract partial record References74Choice_
    {
    }
}
