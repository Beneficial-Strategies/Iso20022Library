// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References41Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References41Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References41Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References41Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References41Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References41Choice.PoolIdentification))]
    [KnownType(typeof(References41Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References41Choice.SecuritiesSettlementTransactionIdentification),nameof(References41Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References41Choice.IntraPositionMovementIdentification),nameof(References41Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References41Choice.IntraBalanceMovementIdentification),nameof(References41Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References41Choice.AccountServicerTransactionIdentification),nameof(References41Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References41Choice.MarketInfrastructureTransactionIdentification),nameof(References41Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References41Choice.PoolIdentification),nameof(References41Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References41Choice.OtherTransactionIdentification),nameof(References41Choice.OtherTransactionIdentification))]
    [IsoId("_P5VgATnrEeWfSKvvZlhRKg")]
    [DisplayName("References 41 Choice")]
    public abstract partial record References41Choice_
    {
    }
}
