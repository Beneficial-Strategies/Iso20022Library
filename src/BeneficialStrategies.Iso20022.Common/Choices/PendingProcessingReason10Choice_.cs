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
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason10Choice.Code))]
    [KnownType(typeof(PendingProcessingReason10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingProcessingReason10Choice.Code),nameof(PendingProcessingReason10Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason10Choice.Proprietary),nameof(PendingProcessingReason10Choice.Proprietary))]
    #endif
    [IsoId("_MpK08TqdEeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Reason 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessingReason10Choice_
    #else
    public abstract partial class PendingProcessingReason10Choice_
    #endif
    {
    }
}
