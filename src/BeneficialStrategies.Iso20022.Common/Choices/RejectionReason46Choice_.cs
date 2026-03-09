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
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason46Choice.Code))]
    [KnownType(typeof(RejectionReason46Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectionReason46Choice.Code),nameof(RejectionReason46Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason46Choice.Proprietary),nameof(RejectionReason46Choice.Proprietary))]
    #endif
    [IsoId("_ddA4qzi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Reason 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason46Choice_
    #else
    public abstract partial class RejectionReason46Choice_
    #endif
    {
    }
}
