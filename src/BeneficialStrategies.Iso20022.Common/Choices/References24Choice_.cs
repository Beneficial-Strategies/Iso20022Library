// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References24Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References24Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References24Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References24Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References24Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References24Choice.PoolIdentification))]
    [KnownType(typeof(References24Choice.CommonIdentification))]
    [KnownType(typeof(References24Choice.TradeIdentification))]
    [KnownType(typeof(References24Choice.OtherTransactionIdentification))]
    [JsonDerivedType(
        typeof(References24Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References24Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.IntraPositionMovementIdentification),
        nameof(References24Choice.IntraPositionMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.IntraBalanceMovementIdentification),
        nameof(References24Choice.IntraBalanceMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.AccountServicerTransactionIdentification),
        nameof(References24Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.MarketInfrastructureTransactionIdentification),
        nameof(References24Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.PoolIdentification),
        nameof(References24Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.CommonIdentification),
        nameof(References24Choice.CommonIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.TradeIdentification),
        nameof(References24Choice.TradeIdentification)
    )]
    [JsonDerivedType(
        typeof(References24Choice.OtherTransactionIdentification),
        nameof(References24Choice.OtherTransactionIdentification)
    )]
    [IsoId("_H-S65_7uEeCvPoRGOxRobQ")]
    [DisplayName("References 24 Choice")]
    public abstract record References24Choice_ { }
}
