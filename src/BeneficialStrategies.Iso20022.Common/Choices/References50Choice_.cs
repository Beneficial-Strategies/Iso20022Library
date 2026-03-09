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
    [KnownType(typeof(References50Choice.SecuritiesSettlementTransactionIdentification))]
    [KnownType(typeof(References50Choice.IntraPositionMovementIdentification))]
    [KnownType(typeof(References50Choice.IntraBalanceMovementIdentification))]
    [KnownType(typeof(References50Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References50Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References50Choice.PoolIdentification))]
    [KnownType(typeof(References50Choice.OtherTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References50Choice.SecuritiesSettlementTransactionIdentification),nameof(References50Choice.SecuritiesSettlementTransactionIdentification))]
    [JsonDerivedType(typeof(References50Choice.IntraPositionMovementIdentification),nameof(References50Choice.IntraPositionMovementIdentification))]
    [JsonDerivedType(typeof(References50Choice.IntraBalanceMovementIdentification),nameof(References50Choice.IntraBalanceMovementIdentification))]
    [JsonDerivedType(typeof(References50Choice.AccountServicerTransactionIdentification),nameof(References50Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References50Choice.MarketInfrastructureTransactionIdentification),nameof(References50Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References50Choice.PoolIdentification),nameof(References50Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References50Choice.OtherTransactionIdentification),nameof(References50Choice.OtherTransactionIdentification))]
    #endif
    [IsoId("_5Pat3ZNLEeWGlc8L7oPDIg")]
    [DisplayName("References 50 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References50Choice_
    #else
    public abstract partial class References50Choice_
    #endif
    {
    }
}
