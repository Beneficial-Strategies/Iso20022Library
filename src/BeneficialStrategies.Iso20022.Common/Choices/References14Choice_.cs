// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References14Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References14Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References14Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References14Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References14Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References14Choice.PoolIdentification))]
    [KnownType(typeof(References14Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References14Choice.SecuritiesSettlementTransactionIdentification),nameof(References14Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References14Choice.IntraPositionMovementIdentification),nameof(References14Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References14Choice.IntraBalanceMovementIdentification),nameof(References14Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References14Choice.AccountServicerTransactionIdentification),nameof(References14Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References14Choice.MarketInfrastructureTransactionIdentification),nameof(References14Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References14Choice.PoolIdentification),nameof(References14Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References14Choice.OtherTransactionIdentification),nameof(References14Choice.OtherTransactionIdentification))]
    [IsoId("_u7dqIeDgEd-udr336SN7mQ")]
    [DisplayName("References 14 Choice")]
    public abstract partial record References14Choice_
    {
    }
}
