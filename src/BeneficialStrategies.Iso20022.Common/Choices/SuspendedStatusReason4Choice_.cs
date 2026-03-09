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
    /// Reason for a suspended status.
    /// </summary>
    [KnownType(typeof(SuspendedStatusReason4Choice.NoSpecifiedReason))]
    [KnownType(typeof(SuspendedStatusReason4Choice.ReasonDetails))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SuspendedStatusReason4Choice.NoSpecifiedReason),nameof(SuspendedStatusReason4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(SuspendedStatusReason4Choice.ReasonDetails),nameof(SuspendedStatusReason4Choice.ReasonDetails))]
    #endif
    [IsoId("_Z5vRgUHlEea8I67lh6qdSQ")]
    [DisplayName("Suspended Status Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SuspendedStatusReason4Choice_
    #else
    public abstract partial class SuspendedStatusReason4Choice_
    #endif
    {
    }
}
