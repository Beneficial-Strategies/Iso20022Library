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
    [KnownType(typeof(PendingProcessingReason11Choice.Code))]
    [KnownType(typeof(PendingProcessingReason11Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PendingProcessingReason11Choice.Code),nameof(PendingProcessingReason11Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason11Choice.Proprietary),nameof(PendingProcessingReason11Choice.Proprietary))]
    #endif
    [IsoId("_DVNwsTqyEeWyoP0PbocV1Q")]
    [DisplayName("Pending Processing Reason 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingProcessingReason11Choice_
    #else
    public abstract partial class PendingProcessingReason11Choice_
    #endif
    {
    }
}
