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
    [KnownType(typeof(References19Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References19Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References19Choice.PoolIdentification))]
    [KnownType(typeof(References19Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References19Choice.ProcessorTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References19Choice.AccountOwnerTransactionIdentification),nameof(References19Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References19Choice.AccountServicerTransactionIdentification),nameof(References19Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References19Choice.PoolIdentification),nameof(References19Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References19Choice.MarketInfrastructureTransactionIdentification),nameof(References19Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References19Choice.ProcessorTransactionIdentification),nameof(References19Choice.ProcessorTransactionIdentification))]
    #endif
    [IsoId("_w7exzUADEeC4mKrqv7wPJQ")]
    [DisplayName("References 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References19Choice_
    #else
    public abstract partial class References19Choice_
    #endif
    {
    }
}
