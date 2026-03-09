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
    [KnownType(typeof(RejectedStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus18Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus18Choice.NoSpecifiedReason),nameof(RejectedStatus18Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus18Choice.Reason),nameof(RejectedStatus18Choice.Reason))]
    #endif
    [IsoId("_F9b6IUGXEeWqy4niLuXETA")]
    [DisplayName("Rejected Status 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus18Choice_
    #else
    public abstract partial class RejectedStatus18Choice_
    #endif
    {
    }
}
