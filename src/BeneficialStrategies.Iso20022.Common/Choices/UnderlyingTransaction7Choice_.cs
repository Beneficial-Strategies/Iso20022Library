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
    [KnownType(typeof(UnderlyingTransaction7Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction7Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction7Choice.StatementEntry))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnderlyingTransaction7Choice.Initiation),nameof(UnderlyingTransaction7Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction7Choice.Interbank),nameof(UnderlyingTransaction7Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction7Choice.StatementEntry),nameof(UnderlyingTransaction7Choice.StatementEntry))]
    #endif
    [IsoId("_ef6I4dcZEeqRFcf2R4bPBw")]
    [DisplayName("Underlying Transaction 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnderlyingTransaction7Choice_
    #else
    public abstract partial class UnderlyingTransaction7Choice_
    #endif
    {
    }
}
