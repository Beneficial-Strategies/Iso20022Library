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
    /// Data to be reconciled.
    /// </summary>
    [KnownType(typeof(ReconciliationMatchedStatus9Choice.Matched))]
    [KnownType(typeof(ReconciliationMatchedStatus9Choice.NotMatched))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReconciliationMatchedStatus9Choice.Matched),nameof(ReconciliationMatchedStatus9Choice.Matched))]
    [JsonDerivedType(typeof(ReconciliationMatchedStatus9Choice.NotMatched),nameof(ReconciliationMatchedStatus9Choice.NotMatched))]
    #endif
    [IsoId("_Av6qZcK3EeuFNp8LZAnorg")]
    [DisplayName("Reconciliation Matched Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReconciliationMatchedStatus9Choice_
    #else
    public abstract partial class ReconciliationMatchedStatus9Choice_
    #endif
    {
    }
}
