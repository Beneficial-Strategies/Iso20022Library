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
    /// Specifies the reason for the reversal of the transaction.
    /// </summary>
    [KnownType(typeof(ReversalReason4Choice.Code))]
    [KnownType(typeof(ReversalReason4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReversalReason4Choice.Code),nameof(ReversalReason4Choice.Code))]
    [JsonDerivedType(typeof(ReversalReason4Choice.Proprietary),nameof(ReversalReason4Choice.Proprietary))]
    #endif
    [IsoId("_TQ8xYNp-Ed-ak6NoX_4Aeg_-340627899")]
    [DisplayName("Reversal Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReversalReason4Choice_
    #else
    public abstract partial class ReversalReason4Choice_
    #endif
    {
    }
}
