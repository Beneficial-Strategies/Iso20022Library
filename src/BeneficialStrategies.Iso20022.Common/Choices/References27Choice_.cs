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
    [KnownType(typeof(References27Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References27Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References27Choice.PoolIdentification))]
    [KnownType(typeof(References27Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References27Choice.ProcessorTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References27Choice.AccountOwnerTransactionIdentification),nameof(References27Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References27Choice.AccountServicerTransactionIdentification),nameof(References27Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References27Choice.PoolIdentification),nameof(References27Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References27Choice.MarketInfrastructureTransactionIdentification),nameof(References27Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References27Choice.ProcessorTransactionIdentification),nameof(References27Choice.ProcessorTransactionIdentification))]
    #endif
    [IsoId("_mKkkp_7xEeCvPoRGOxRobQ")]
    [DisplayName("References 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References27Choice_
    #else
    public abstract partial class References27Choice_
    #endif
    {
    }
}
