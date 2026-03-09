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
    [KnownType(typeof(PendingReason29Choice.Code))]
    [KnownType(typeof(PendingReason29Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason29Choice.Code),nameof(PendingReason29Choice.Code))]
    [JsonDerivedType(typeof(PendingReason29Choice.Proprietary),nameof(PendingReason29Choice.Proprietary))]
    #endif
    [IsoId("_6FsGETqxEeWyoP0PbocV1Q")]
    [DisplayName("Pending Reason 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason29Choice_
    #else
    public abstract partial class PendingReason29Choice_
    #endif
    {
    }
}
