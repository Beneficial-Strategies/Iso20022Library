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
    [KnownType(typeof(References75Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References75Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References75Choice.PoolIdentification))]
    [KnownType(typeof(References75Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References75Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References75Choice.ProcessorTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References75Choice.AccountOwnerTransactionIdentification),nameof(References75Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References75Choice.AccountServicerTransactionIdentification),nameof(References75Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References75Choice.PoolIdentification),nameof(References75Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References75Choice.MarketInfrastructureTransactionIdentification),nameof(References75Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References75Choice.CounterpartyMarketInfrastructureTransactionIdentification),nameof(References75Choice.CounterpartyMarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References75Choice.ProcessorTransactionIdentification),nameof(References75Choice.ProcessorTransactionIdentification))]
    #endif
    [IsoId("_ccpnozi8Eeydid5dcNPKvg")]
    [DisplayName("References 75 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References75Choice_
    #else
    public abstract partial class References75Choice_
    #endif
    {
    }
}
