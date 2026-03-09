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
    [KnownType(typeof(ProcessingStatus83Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus83Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus83Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus83Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus83Choice.Repair))]
    [KnownType(typeof(ProcessingStatus83Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus83Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus83Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus83Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus83Choice.PendingCancellation),nameof(ProcessingStatus83Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.AcknowledgedAccepted),nameof(ProcessingStatus83Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.PendingProcessing),nameof(ProcessingStatus83Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Rejected),nameof(ProcessingStatus83Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Repair),nameof(ProcessingStatus83Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Cancelled),nameof(ProcessingStatus83Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.Proprietary),nameof(ProcessingStatus83Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.CancellationRequested),nameof(ProcessingStatus83Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus83Choice.ModificationRequested),nameof(ProcessingStatus83Choice.ModificationRequested))]
    #endif
    [IsoId("_MnoZgStVEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 83 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus83Choice_
    #else
    public abstract partial class ProcessingStatus83Choice_
    #endif
    {
    }
}
