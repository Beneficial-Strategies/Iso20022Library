// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References54Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References54Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References54Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References54Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References54Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References54Choice.PoolIdentification))]
    [KnownType(typeof(References54Choice.CommonIdentification))]
    [KnownType(typeof(References54Choice.TradeIdentification))]
    [KnownType(typeof(References54Choice.OtherTransactionIdentification))]
    [JsonDerivedType(
        typeof(References54Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References54Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.IntraPositionMovementIdentification),
        nameof(References54Choice.IntraPositionMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.IntraBalanceMovementIdentification),
        nameof(References54Choice.IntraBalanceMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.AccountServicerTransactionIdentification),
        nameof(References54Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.MarketInfrastructureTransactionIdentification),
        nameof(References54Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.PoolIdentification),
        nameof(References54Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.CommonIdentification),
        nameof(References54Choice.CommonIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.TradeIdentification),
        nameof(References54Choice.TradeIdentification)
    )]
    [JsonDerivedType(
        typeof(References54Choice.OtherTransactionIdentification),
        nameof(References54Choice.OtherTransactionIdentification)
    )]
    [IsoId("_6GW87ZNLEeWGlc8L7oPDIg")]
    [DisplayName("References 54 Choice")]
    public abstract record References54Choice_ { }
}
