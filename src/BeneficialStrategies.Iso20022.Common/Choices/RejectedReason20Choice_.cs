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
    /// Choice between formats for a rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason20Choice.Code))]
    [KnownType(typeof(RejectedReason20Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RejectedReason20Choice.Code),nameof(RejectedReason20Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason20Choice.Proprietary),nameof(RejectedReason20Choice.Proprietary))]
    #endif
    [IsoId("_aD_roUHjEea8I67lh6qdSQ")]
    [DisplayName("Rejected Reason 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectedReason20Choice_
    #else
    public abstract partial class RejectedReason20Choice_
    #endif
    {
    }
}
