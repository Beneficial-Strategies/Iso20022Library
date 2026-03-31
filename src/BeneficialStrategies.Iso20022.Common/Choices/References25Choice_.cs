// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References25Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References25Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References25Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References25Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References25Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References25Choice.PoolIdentification))]
    [KnownType(typeof(References25Choice.OtherTransactionIdentification))]
    [JsonDerivedType(
        typeof(References25Choice.SecuritiesSettlementTransactionIdentification),
        nameof(References25Choice.SecuritiesSettlementTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References25Choice.IntraPositionMovementIdentification),
        nameof(References25Choice.IntraPositionMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References25Choice.IntraBalanceMovementIdentification),
        nameof(References25Choice.IntraBalanceMovementIdentification)
    )]
    [JsonDerivedType(
        typeof(References25Choice.AccountServicerTransactionIdentification),
        nameof(References25Choice.AccountServicerTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References25Choice.MarketInfrastructureTransactionIdentification),
        nameof(References25Choice.MarketInfrastructureTransactionIdentification)
    )]
    [JsonDerivedType(
        typeof(References25Choice.PoolIdentification),
        nameof(References25Choice.PoolIdentification)
    )]
    [JsonDerivedType(
        typeof(References25Choice.OtherTransactionIdentification),
        nameof(References25Choice.OtherTransactionIdentification)
    )]
    [IsoId("_XGKRbf7uEeCvPoRGOxRobQ")]
    [DisplayName("References 25 Choice")]
    public abstract record References25Choice_ { }
}
