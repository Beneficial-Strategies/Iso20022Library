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
    [KnownType(typeof(References51Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References51Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References51Choice.PoolIdentification))]
    [KnownType(typeof(References51Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References51Choice.ProcessorTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References51Choice.AccountOwnerTransactionIdentification),nameof(References51Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References51Choice.AccountServicerTransactionIdentification),nameof(References51Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References51Choice.PoolIdentification),nameof(References51Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References51Choice.MarketInfrastructureTransactionIdentification),nameof(References51Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References51Choice.ProcessorTransactionIdentification),nameof(References51Choice.ProcessorTransactionIdentification))]
    #endif
    [IsoId("_5Qz08ZNLEeWGlc8L7oPDIg")]
    [DisplayName("References 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References51Choice_
    #else
    public abstract partial class References51Choice_
    #endif
    {
    }
}
