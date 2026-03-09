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
    [KnownType(typeof(References66Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References66Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References66Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References66Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References66Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References66Choice.PoolIdentification))]
    [KnownType(typeof(References66Choice.CommonIdentification))]
    [KnownType(typeof(References66Choice.TradeIdentification))]
    [KnownType(typeof(References66Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References66Choice.SecuritiesSettlementTransactionIdentification),nameof(References66Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References66Choice.IntraPositionMovementIdentification),nameof(References66Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References66Choice.IntraBalanceMovementIdentification),nameof(References66Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References66Choice.AccountServicerTransactionIdentification),nameof(References66Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References66Choice.MarketInfrastructureTransactionIdentification),nameof(References66Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References66Choice.PoolIdentification),nameof(References66Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References66Choice.CommonIdentification),nameof(References66Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References66Choice.TradeIdentification),nameof(References66Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References66Choice.OtherTransactionIdentification),nameof(References66Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_Lovo8fyjEeiM0vtizCHcoA")]
    [DisplayName("References 66 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References66Choice_
    #else
    public abstract partial class References66Choice_
    #endif
    {
    }
}
