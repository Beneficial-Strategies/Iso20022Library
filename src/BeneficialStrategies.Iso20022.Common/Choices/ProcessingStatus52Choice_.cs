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
    [KnownType(typeof(ProcessingStatus52Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus52Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus52Choice.Repair))]
    [KnownType(typeof(ProcessingStatus52Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus52Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus52Choice.CancellationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus52Choice.AcknowledgedAccepted),nameof(ProcessingStatus52Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus52Choice.PendingProcessing),nameof(ProcessingStatus52Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus52Choice.Repair),nameof(ProcessingStatus52Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus52Choice.PendingCancellation),nameof(ProcessingStatus52Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus52Choice.Proprietary),nameof(ProcessingStatus52Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus52Choice.CancellationRequested),nameof(ProcessingStatus52Choice.CancellationRequested))]
    #endif
    [IsoId("_k4_NAznvEeWfSKvvZlhRKg")]
    [DisplayName("Processing Status 52 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus52Choice_
    #else
    public abstract partial class ProcessingStatus52Choice_
    #endif
    {
    }
}
