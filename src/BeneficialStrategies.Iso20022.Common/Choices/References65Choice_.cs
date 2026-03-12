// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between references.
    /// </summary>
    [KnownType(typeof(References65Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References65Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References65Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References65Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References65Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References65Choice.PoolIdentification))]
    [KnownType(typeof(References65Choice.CommonIdentification))]
    [KnownType(typeof(References65Choice.TradeIdentification))]
    [KnownType(typeof(References65Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References65Choice.SecuritiesSettlementTransactionIdentification),nameof(References65Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References65Choice.IntraPositionMovementIdentification),nameof(References65Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References65Choice.IntraBalanceMovementIdentification),nameof(References65Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References65Choice.AccountServicerTransactionIdentification),nameof(References65Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References65Choice.MarketInfrastructureTransactionIdentification),nameof(References65Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References65Choice.PoolIdentification),nameof(References65Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References65Choice.CommonIdentification),nameof(References65Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References65Choice.TradeIdentification),nameof(References65Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References65Choice.OtherTransactionIdentification),nameof(References65Choice.OtherTransactionIdentification))]
    [IsoId("_03jkTdBwEeihG9bKfarOOA")]
    [DisplayName("References 65 Choice")]
    public abstract partial record References65Choice_
    {
    }
}
