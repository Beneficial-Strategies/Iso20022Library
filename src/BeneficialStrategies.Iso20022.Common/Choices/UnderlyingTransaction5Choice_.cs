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
    /// Provides details of the underlying transaction, on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction5Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction5Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction5Choice.StatementEntry))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingTransaction5Choice.Initiation),nameof(UnderlyingTransaction5Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction5Choice.Interbank),nameof(UnderlyingTransaction5Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction5Choice.StatementEntry),nameof(UnderlyingTransaction5Choice.StatementEntry))]
    #endif
    [IsoId("_IGwpoW49EeiU9cctagi5ow")]
    [DisplayName("Underlying Transaction 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingTransaction5Choice_
    #else
    public abstract partial class UnderlyingTransaction5Choice_
    #endif
    {
    }
}
