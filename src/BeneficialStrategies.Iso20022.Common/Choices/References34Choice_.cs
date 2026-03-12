// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references.
    /// </summary>
    [KnownType(typeof(References34Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References34Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References34Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References34Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References34Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References34Choice.PoolIdentification))]
    [KnownType(typeof(References34Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References34Choice.SecuritiesSettlementTransactionIdentification),nameof(References34Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References34Choice.IntraPositionMovementIdentification),nameof(References34Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References34Choice.IntraBalanceMovementIdentification),nameof(References34Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References34Choice.AccountServicerTransactionIdentification),nameof(References34Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References34Choice.MarketInfrastructureTransactionIdentification),nameof(References34Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References34Choice.PoolIdentification),nameof(References34Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References34Choice.OtherTransactionIdentification),nameof(References34Choice.OtherTransactionIdentification))]
    [IsoId("_jvDnxu5NEeCisYr99QEiWA_1809359150")]
    [DisplayName("References 34 Choice")]
    public abstract partial record References34Choice_
    {
    }
}
