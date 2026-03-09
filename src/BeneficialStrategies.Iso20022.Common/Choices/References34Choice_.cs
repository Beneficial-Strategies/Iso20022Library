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
    /// Choice of references.
    /// </summary>
    [KnownType(typeof(References34Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References34Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References34Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References34Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References34Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References34Choice.PoolIdentification))]
    [KnownType(typeof(References34Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References34Choice.SecuritiesSettlementTransactionIdentification),nameof(References34Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References34Choice.IntraPositionMovementIdentification),nameof(References34Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References34Choice.IntraBalanceMovementIdentification),nameof(References34Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References34Choice.AccountServicerTransactionIdentification),nameof(References34Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References34Choice.MarketInfrastructureTransactionIdentification),nameof(References34Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References34Choice.PoolIdentification),nameof(References34Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References34Choice.OtherTransactionIdentification),nameof(References34Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_jvDnxu5NEeCisYr99QEiWA_1809359150")]
    [DisplayName("References 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References34Choice_
    #else
    public abstract partial class References34Choice_
    #endif
    {
    }
}
