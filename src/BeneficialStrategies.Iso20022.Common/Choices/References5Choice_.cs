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
    [KnownType(typeof(References5Choice.AccountOwnerTransactionIdentification))]
    [KnownType(typeof(References5Choice.AccountServicerTransactionIdentification))]
    [KnownType(typeof(References5Choice.PoolIdentification))]
    [KnownType(typeof(References5Choice.MarketInfrastructureTransactionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References5Choice.AccountOwnerTransactionIdentification),nameof(References5Choice.AccountOwnerTransactionIdentification))]
    [JsonDerivedType(typeof(References5Choice.AccountServicerTransactionIdentification),nameof(References5Choice.AccountServicerTransactionIdentification))]
    [JsonDerivedType(typeof(References5Choice.PoolIdentification),nameof(References5Choice.PoolIdentification))]
    [JsonDerivedType(typeof(References5Choice.MarketInfrastructureTransactionIdentification),nameof(References5Choice.MarketInfrastructureTransactionIdentification))]
    #endif
    [IsoId("_USg8Htp-Ed-ak6NoX_4Aeg_-283590354")]
    [DisplayName("References 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References5Choice_
    #else
    public abstract partial class References5Choice_
    #endif
    {
    }
}
