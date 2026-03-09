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
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus19Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus19Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus19Choice.NoSpecifiedReason),nameof(RejectedStatus19Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus19Choice.Reason),nameof(RejectedStatus19Choice.Reason))]
    #endif
    [IsoId("_9NvRAUGUEeWqy4niLuXETA")]
    [DisplayName("Rejected Status 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus19Choice_
    #else
    public abstract partial class RejectedStatus19Choice_
    #endif
    {
    }
}
