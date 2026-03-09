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
    [KnownType(typeof(RejectedReason47Choice.Code))]
    [KnownType(typeof(RejectedReason47Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedReason47Choice.Code),nameof(RejectedReason47Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason47Choice.Proprietary),nameof(RejectedReason47Choice.Proprietary))]
    #endif
    [IsoId("_pf-JgTi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Reason 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason47Choice_
    #else
    public abstract partial class RejectedReason47Choice_
    #endif
    {
    }
}
