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
    [KnownType(typeof(References42Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References42Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References42Choice.PoolIdentification))]
    [KnownType(typeof(References42Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References42Choice.ProcessorTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References42Choice.AccountOwnerTransactionIdentification),nameof(References42Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References42Choice.AccountServicerTransactionIdentification),nameof(References42Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References42Choice.PoolIdentification),nameof(References42Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References42Choice.MarketInfrastructureTransactionIdentification),nameof(References42Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References42Choice.ProcessorTransactionIdentification),nameof(References42Choice.ProcessorTransactionIdentification))]
    #endif
    [IsoId("_FlUvwTp-EeWVrPy0StzzSg")]
    [DisplayName("References 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References42Choice_
    #else
    public abstract partial class References42Choice_
    #endif
    {
    }
}
