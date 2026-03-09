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
    [KnownType(typeof(References25Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References25Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References25Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References25Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References25Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References25Choice.PoolIdentification))]
    [KnownType(typeof(References25Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References25Choice.SecuritiesSettlementTransactionIdentification),nameof(References25Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References25Choice.IntraPositionMovementIdentification),nameof(References25Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References25Choice.IntraBalanceMovementIdentification),nameof(References25Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References25Choice.AccountServicerTransactionIdentification),nameof(References25Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References25Choice.MarketInfrastructureTransactionIdentification),nameof(References25Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References25Choice.PoolIdentification),nameof(References25Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References25Choice.OtherTransactionIdentification),nameof(References25Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_XGKRbf7uEeCvPoRGOxRobQ")]
    [DisplayName("References 25 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References25Choice_
    #else
    public abstract partial class References25Choice_
    #endif
    {
    }
}
