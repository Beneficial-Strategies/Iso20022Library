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
    /// Reason for the reversal of the transaction.
    /// </summary>
    [KnownType(typeof(ReversalReason3Choice.Code))]
    [KnownType(typeof(ReversalReason3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReversalReason3Choice.Code),nameof(ReversalReason3Choice.Code))]
    [JsonDerivedType(typeof(ReversalReason3Choice.Proprietary),nameof(ReversalReason3Choice.Proprietary))]
    #endif
    [IsoId("_V8nGZdp-Ed-ak6NoX_4Aeg_-801418464")]
    [DisplayName("Reversal Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReversalReason3Choice_
    #else
    public abstract partial class ReversalReason3Choice_
    #endif
    {
    }
}
