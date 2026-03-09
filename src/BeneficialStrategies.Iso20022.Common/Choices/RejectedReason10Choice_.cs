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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason10Choice.Code))]
    [KnownType(typeof(RejectedReason10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedReason10Choice.Code),nameof(RejectedReason10Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason10Choice.Proprietary),nameof(RejectedReason10Choice.Proprietary))]
    #endif
    [IsoId("_2dRqY1hnEeSsH9MSoogb7Q")]
    [DisplayName("Rejected Reason 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason10Choice_
    #else
    public abstract partial class RejectedReason10Choice_
    #endif
    {
    }
}
