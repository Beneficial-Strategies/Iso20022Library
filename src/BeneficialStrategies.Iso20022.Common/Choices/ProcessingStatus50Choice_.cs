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
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus50Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus50Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus50Choice.Completed))]
    [KnownType(typeof(ProcessingStatus50Choice.Denied))]
    [KnownType(typeof(ProcessingStatus50Choice.Pending))]
    [KnownType(typeof(ProcessingStatus50Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus50Choice.AcknowledgedAccepted),nameof(ProcessingStatus50Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus50Choice.Rejected),nameof(ProcessingStatus50Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus50Choice.Completed),nameof(ProcessingStatus50Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus50Choice.Denied),nameof(ProcessingStatus50Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus50Choice.Pending),nameof(ProcessingStatus50Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus50Choice.Proprietary),nameof(ProcessingStatus50Choice.Proprietary))]
    #endif
    [IsoId("_iSz08TnvEeWfSKvvZlhRKg")]
    [DisplayName("Processing Status 50 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus50Choice_
    #else
    public abstract partial class ProcessingStatus50Choice_
    #endif
    {
    }
}
