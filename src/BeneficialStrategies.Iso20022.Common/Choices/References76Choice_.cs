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
    /// Choice between references.
    /// </summary>
    [KnownType(typeof(References76Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References76Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References76Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References76Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References76Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References76Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References76Choice.PoolIdentification))]
    [KnownType(typeof(References76Choice.CommonIdentification))]
    [KnownType(typeof(References76Choice.TradeIdentification))]
    [KnownType(typeof(References76Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References76Choice.SecuritiesSettlementTransactionIdentification),nameof(References76Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References76Choice.IntraPositionMovementIdentification),nameof(References76Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References76Choice.IntraBalanceMovementIdentification),nameof(References76Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References76Choice.AccountServicerTransactionIdentification),nameof(References76Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References76Choice.MarketInfrastructureTransactionIdentification),nameof(References76Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References76Choice.CounterpartyMarketInfrastructureTransactionIdentification),nameof(References76Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References76Choice.PoolIdentification),nameof(References76Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References76Choice.CommonIdentification),nameof(References76Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References76Choice.TradeIdentification),nameof(References76Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References76Choice.OtherTransactionIdentification),nameof(References76Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_diXSsTi8Eeydid5dcNPKvg")]
    [DisplayName("References 76 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References76Choice_
    #else
    public abstract partial class References76Choice_
    #endif
    {
    }
}
