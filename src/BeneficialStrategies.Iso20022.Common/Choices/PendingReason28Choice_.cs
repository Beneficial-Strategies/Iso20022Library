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
    [KnownType(typeof(PendingReason28Choice.Code))]
    [KnownType(typeof(PendingReason28Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingReason28Choice.Code),nameof(PendingReason28Choice.Code))]
    [JsonDerivedType(typeof(PendingReason28Choice.Proprietary),nameof(PendingReason28Choice.Proprietary))]
    #endif
    [IsoId("_GnAMQTqfEeWyoP0PbocV1Q")]
    [DisplayName("Pending Reason 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason28Choice_
    #else
    public abstract partial class PendingReason28Choice_
    #endif
    {
    }
}
