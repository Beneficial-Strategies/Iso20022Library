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
    [KnownType(typeof(ProcessingStatus87Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus87Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus87Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus87Choice.Repair))]
    [KnownType(typeof(ProcessingStatus87Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus87Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus87Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus87Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus87Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus87Choice.AcknowledgedAccepted),nameof(ProcessingStatus87Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.PendingProcessing),nameof(ProcessingStatus87Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.Rejected),nameof(ProcessingStatus87Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.Repair),nameof(ProcessingStatus87Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.Cancelled),nameof(ProcessingStatus87Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.PendingCancellation),nameof(ProcessingStatus87Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.Proprietary),nameof(ProcessingStatus87Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.CancellationRequested),nameof(ProcessingStatus87Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus87Choice.ModificationRequested),nameof(ProcessingStatus87Choice.ModificationRequested))]
    #endif
    [IsoId("_qvERsStWEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 87 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus87Choice_
    #else
    public abstract partial class ProcessingStatus87Choice_
    #endif
    {
    }
}
