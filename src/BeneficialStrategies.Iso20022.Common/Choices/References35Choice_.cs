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
    /// References of the original instruction for which an action has been requested.
    /// </summary>
    [KnownType(typeof(References35Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References35Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References35Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References35Choice.ProcessorTransactionIdentification))]
    [KnownType(typeof(References35Choice.PoolIdentification))]
    [KnownType(typeof(References35Choice.CommonIdentification))]
    [KnownType(typeof(References35Choice.TradeIdentification))]
    [KnownType(typeof(References35Choice.CorporateActionEventIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References35Choice.AccountOwnerTransactionIdentification),nameof(References35Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References35Choice.AccountServicerTransactionIdentification),nameof(References35Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References35Choice.MarketInfrastructureTransactionIdentification),nameof(References35Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References35Choice.ProcessorTransactionIdentification),nameof(References35Choice.ProcessorTransactionIdentification))]
    [JsonDerivedType(typeof(References35Choice.PoolIdentification),nameof(References35Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References35Choice.CommonIdentification),nameof(References35Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References35Choice.TradeIdentification),nameof(References35Choice.TradeIdentification))]
    [JsonDerivedType(typeof(References35Choice.CorporateActionEventIdentification),nameof(References35Choice.CorporateActionEventIdentification))]
    #endif
    [IsoId("_jvWisO5NEeCisYr99QEiWA_-696933673")]
    [DisplayName("References 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References35Choice_
    #else
    public abstract partial class References35Choice_
    #endif
    {
    }
}
