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
    [KnownType(typeof(RejectedStatus9Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus9Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus9Choice.NoSpecifiedReason),nameof(RejectedStatus9Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus9Choice.Reason),nameof(RejectedStatus9Choice.Reason))]
    #endif
    [IsoId("_POQgwSd0EeOXAt_43VmZGw")]
    [DisplayName("Rejected Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus9Choice_
    #else
    public abstract partial class RejectedStatus9Choice_
    #endif
    {
    }
}
