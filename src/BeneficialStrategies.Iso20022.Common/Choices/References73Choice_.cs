// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References73Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References73Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References73Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References73Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References73Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References73Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References73Choice.PoolIdentification))]
    [KnownType(typeof(References73Choice.OtherTransactionIdentification))]
    [JsonDerivedType(typeof(References73Choice.SecuritiesSettlementTransactionIdentification),nameof(References73Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References73Choice.IntraPositionMovementIdentification),nameof(References73Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References73Choice.IntraBalanceMovementIdentification),nameof(References73Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References73Choice.AccountServicerTransactionIdentification),nameof(References73Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References73Choice.MarketInfrastructureTransactionIdentification),nameof(References73Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References73Choice.CounterpartyMarketInfrastructureTransactionIdentification),nameof(References73Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References73Choice.PoolIdentification),nameof(References73Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References73Choice.OtherTransactionIdentification),nameof(References73Choice.OtherTransactionIdentification))]
    [IsoId("_N6yrtygVEeym1_Zp1BTvEw")]
    [DisplayName("References 73 Choice")]
    public abstract partial record References73Choice_
    {
    }
}
