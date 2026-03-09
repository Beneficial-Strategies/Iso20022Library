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
    /// Choice between a reason and no reason for the general meeting instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus44Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus44Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedStatus44Choice.NoSpecifiedReason),nameof(RejectedStatus44Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus44Choice.Reason),nameof(RejectedStatus44Choice.Reason))]
    #endif
    [IsoId("_htjMqRrpEeyhRdHRjakS2w")]
    [DisplayName("Rejected Status 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedStatus44Choice_
    #else
    public abstract partial class RejectedStatus44Choice_
    #endif
    {
    }
}
