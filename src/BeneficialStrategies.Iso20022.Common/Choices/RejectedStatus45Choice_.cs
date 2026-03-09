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
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus45Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus45Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus45Choice.NoSpecifiedReason),nameof(RejectedStatus45Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus45Choice.Reason),nameof(RejectedStatus45Choice.Reason))]
    #endif
    [IsoId("_pf-JVTi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Status 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus45Choice_
    #else
    public abstract partial class RejectedStatus45Choice_
    #endif
    {
    }
}
