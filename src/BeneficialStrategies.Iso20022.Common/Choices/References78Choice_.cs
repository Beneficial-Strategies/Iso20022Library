// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References78Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References78Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References78Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References78Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References78Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(
        typeof(References78Choice.CounterpartyMarketInfrastructureTransactionIdentification)
    )]
    [KnownType(typeof(References78Choice.PoolIdentification))]
    [KnownType(typeof(References78Choice.OtherTransactionIdentification))]
    [JsonDerivedType(
        typeof(References78Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References78Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References78Choice.IntraPositionMovementIdentification),
        nameof(References78Choice.IntraPositionMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References78Choice.IntraBalanceMovementIdentification),
        nameof(References78Choice.IntraBalanceMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References78Choice.AccountServicerTransactionIdentification),
        nameof(References78Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References78Choice.MarketInfrastructureTransactionIdentification),
        nameof(References78Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References78Choice.CounterpartyMarketInfrastructureTransactionIdentification),
        nameof(References78Choice.CounterpartyMarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References78Choice.PoolIdentification),
        nameof(References78Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References78Choice.OtherTransactionIdentification),
        nameof(References78Choice.OtherTransactionIdentification)
    )]
    [IsoId("_d_pEWzi8Eeydid5dcNPKvg")]
    [DisplayName("References 78 Choice")]
    public abstract record References78Choice_ { }
}
