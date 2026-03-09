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
    [KnownType(typeof(References6Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References6Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References6Choice.MarketInfrastructureTransactionIdentification))]
    [KnownType(typeof(References6Choice.PoolIdentification))]
    [KnownType(typeof(References6Choice.CommonIdentification))]
    [KnownType(typeof(References6Choice.TradeIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References6Choice.AccountServicerTransactionIdentification),nameof(References6Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References6Choice.AccountOwnerTransactionIdentification),nameof(References6Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References6Choice.MarketInfrastructureTransactionIdentification),nameof(References6Choice.MarketInfrastructureTransactionIdentification))]
    [JsonDerivedType(typeof(References6Choice.PoolIdentification),nameof(References6Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References6Choice.CommonIdentification),nameof(References6Choice.CommonIdentification))]
    [JsonDerivedType(typeof(References6Choice.TradeIdentification),nameof(References6Choice.TradeIdentification))]
    #endif
    [IsoId("_UTGx8Np-Ed-ak6NoX_4Aeg_1758264340")]
    [DisplayName("References 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References6Choice_
    #else
    public abstract partial class References6Choice_
    #endif
    {
    }
}
