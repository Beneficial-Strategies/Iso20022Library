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
    /// Choice between a standard code and proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason44Choice.Code))]
    [KnownType(typeof(RejectedReason44Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedReason44Choice.Code),nameof(RejectedReason44Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason44Choice.Proprietary),nameof(RejectedReason44Choice.Proprietary))]
    #endif
    [IsoId("_iW99IxrpEeyhRdHRjakS2w")]
    [DisplayName("Rejected Reason 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason44Choice_
    #else
    public abstract partial class RejectedReason44Choice_
    #endif
    {
    }
}
