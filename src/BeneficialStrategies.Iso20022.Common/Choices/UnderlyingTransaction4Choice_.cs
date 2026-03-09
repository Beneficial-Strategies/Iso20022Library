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
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction4Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction4Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction4Choice.StatementEntry))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingTransaction4Choice.Initiation),nameof(UnderlyingTransaction4Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction4Choice.Interbank),nameof(UnderlyingTransaction4Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction4Choice.StatementEntry),nameof(UnderlyingTransaction4Choice.StatementEntry))]
    #endif
    [IsoId("_hRwhsYKZEee7hrXqLO3yQg")]
    [DisplayName("Underlying Transaction 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingTransaction4Choice_
    #else
    public abstract partial class UnderlyingTransaction4Choice_
    #endif
    {
    }
}
