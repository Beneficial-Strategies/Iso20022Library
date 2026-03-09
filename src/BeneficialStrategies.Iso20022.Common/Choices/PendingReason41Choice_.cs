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
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason41Choice.Code))]
    [KnownType(typeof(PendingReason41Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason41Choice.Code),nameof(PendingReason41Choice.Code))]
    [JsonDerivedType(typeof(PendingReason41Choice.Proprietary),nameof(PendingReason41Choice.Proprietary))]
    #endif
    [IsoId("_6QB2R5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason41Choice_
    #else
    public abstract partial class PendingReason41Choice_
    #endif
    {
    }
}
