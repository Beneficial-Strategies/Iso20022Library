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
    [KnownType(typeof(References13Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References13Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References13Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References13Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References13Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References13Choice.PoolIdentification))]
    [KnownType(typeof(References13Choice.CommonIdentification))]
    [KnownType(typeof(References13Choice.TradeIdentification))]
    [KnownType(typeof(References13Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References13Choice.SecuritiesSettlementTransactionIdentification),nameof(References13Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References13Choice.IntraPositionMovementIdentification),nameof(References13Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References13Choice.IntraBalanceMovementIdentification),nameof(References13Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References13Choice.AccountServicerTransactionIdentification),nameof(References13Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References13Choice.MarketInfrastructureTransactionIdentification),nameof(References13Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References13Choice.PoolIdentification),nameof(References13Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References13Choice.CommonIdentification),nameof(References13Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References13Choice.TradeIdentification),nameof(References13Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References13Choice.OtherTransactionIdentification),nameof(References13Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_-1br8fuZEd-Qm92hXFsDlA")]
    [DisplayName("References 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References13Choice_
    #else
    public abstract partial class References13Choice_
    #endif
    {
    }
}
