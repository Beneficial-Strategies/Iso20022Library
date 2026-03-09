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
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason17Choice.Code))]
    [KnownType(typeof(RejectedReason17Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedReason17Choice.Code),nameof(RejectedReason17Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason17Choice.Proprietary),nameof(RejectedReason17Choice.Proprietary))]
    #endif
    [IsoId("_-Fir4SYuEeW_ZNn8gbfY7Q")]
    [DisplayName("Rejected Reason 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason17Choice_
    #else
    public abstract partial class RejectedReason17Choice_
    #endif
    {
    }
}
