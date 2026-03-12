// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References50Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References50Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References50Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References50Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References50Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References50Choice.PoolIdentification))]
    [KnownType(typeof(References50Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References50Choice.SecuritiesSettlementTransactionIdentification),nameof(References50Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References50Choice.IntraPositionMovementIdentification),nameof(References50Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References50Choice.IntraBalanceMovementIdentification),nameof(References50Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References50Choice.AccountServicerTransactionIdentification),nameof(References50Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References50Choice.MarketInfrastructureTransactionIdentification),nameof(References50Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References50Choice.PoolIdentification),nameof(References50Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References50Choice.OtherTransactionIdentification),nameof(References50Choice.OtherTransactionIdentification))]
    [IsoId("_5Pat3ZNLEeWGlc8L7oPDIg")]
    [DisplayName("References 50 Choice")]
    public abstract partial record References50Choice_
    {
    }
}
