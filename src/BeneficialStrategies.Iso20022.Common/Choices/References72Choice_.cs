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
    [KnownType(typeof(References72Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References72Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References72Choice.PoolIdentification))]
    [KnownType(typeof(References72Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References72Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References72Choice.ProcessorTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References72Choice.AccountOwnerTransactionIdentification),nameof(References72Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References72Choice.AccountServicerTransactionIdentification),nameof(References72Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References72Choice.PoolIdentification),nameof(References72Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References72Choice.MarketInfrastructureTransactionIdentification),nameof(References72Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References72Choice.CounterpartyMarketInfrastructureTransactionIdentification),nameof(References72Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References72Choice.ProcessorTransactionIdentification),nameof(References72Choice.ProcessorTransactionIdentification))]
    #endif
    [IsoId("_7AFuYSgPEeym1_Zp1BTvEw")]
    [DisplayName("References 72 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References72Choice_
    #else
    public abstract partial class References72Choice_
    #endif
    {
    }
}
