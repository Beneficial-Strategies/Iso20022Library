// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References13Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References13Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References13Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References13Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References13Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References13Choice.PoolIdentification))]
    [KnownType(typeof(References13Choice.CommonIdentification))]
    [KnownType(typeof(References13Choice.TradeIdentification))]
    [KnownType(typeof(References13Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References13Choice.SecuritiesSettlementTransactionIdentification),nameof(References13Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References13Choice.IntraPositionMovementIdentification),nameof(References13Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References13Choice.IntraBalanceMovementIdentification),nameof(References13Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References13Choice.AccountServicerTransactionIdentification),nameof(References13Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References13Choice.MarketInfrastructureTransactionIdentification),nameof(References13Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References13Choice.PoolIdentification),nameof(References13Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References13Choice.CommonIdentification),nameof(References13Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References13Choice.TradeIdentification),nameof(References13Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References13Choice.OtherTransactionIdentification),nameof(References13Choice.OtherTransactionIdentification))]
    [IsoId("_-1br8fuZEd-Qm92hXFsDlA")]
    [DisplayName("References 13 Choice")]
    public abstract partial record References13Choice_
    {
    }
}
