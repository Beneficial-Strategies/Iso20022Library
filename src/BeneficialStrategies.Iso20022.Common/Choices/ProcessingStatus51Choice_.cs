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
    [KnownType(typeof(ProcessingStatus51Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus51Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus51Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus51Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus51Choice.Repair))]
    [KnownType(typeof(ProcessingStatus51Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus51Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus51Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus51Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus51Choice.PendingCancellation),nameof(ProcessingStatus51Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.AcknowledgedAccepted),nameof(ProcessingStatus51Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.PendingProcessing),nameof(ProcessingStatus51Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.Rejected),nameof(ProcessingStatus51Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.Repair),nameof(ProcessingStatus51Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.Cancelled),nameof(ProcessingStatus51Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.Proprietary),nameof(ProcessingStatus51Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.CancellationRequested),nameof(ProcessingStatus51Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus51Choice.ModificationRequested),nameof(ProcessingStatus51Choice.ModificationRequested))]
    #endif
    [IsoId("_i1LiRznvEeWfSKvvZlhRKg")]
    [DisplayName("Processing Status 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus51Choice_
    #else
    public abstract partial class ProcessingStatus51Choice_
    #endif
    {
    }
}
