// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of reference.
    /// </summary>
    [KnownType(typeof(References78Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References78Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References78Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References78Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References78Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References78Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References78Choice.PoolIdentification))]
    [KnownType(typeof(References78Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References78Choice.SecuritiesSettlementTransactionIdentification),nameof(References78Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References78Choice.IntraPositionMovementIdentification),nameof(References78Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References78Choice.IntraBalanceMovementIdentification),nameof(References78Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References78Choice.AccountServicerTransactionIdentification),nameof(References78Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References78Choice.MarketInfrastructureTransactionIdentification),nameof(References78Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References78Choice.CounterpartyMarketInfrastructureTransactionIdentification),nameof(References78Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References78Choice.PoolIdentification),nameof(References78Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References78Choice.OtherTransactionIdentification),nameof(References78Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_d_pEWzi8Eeydid5dcNPKvg")]
    [DisplayName("References 78 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References78Choice_
    #else
    public abstract partial class References78Choice_
    #endif
    {
    }
}
