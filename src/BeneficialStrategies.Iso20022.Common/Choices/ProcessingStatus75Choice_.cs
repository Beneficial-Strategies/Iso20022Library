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
    [KnownType(typeof(ProcessingStatus75Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus75Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus75Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus75Choice.Repair))]
    [KnownType(typeof(ProcessingStatus75Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus75Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus75Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus75Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus75Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus75Choice.AcknowledgedAccepted),nameof(ProcessingStatus75Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.PendingProcessing),nameof(ProcessingStatus75Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.Rejected),nameof(ProcessingStatus75Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.Repair),nameof(ProcessingStatus75Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.Cancelled),nameof(ProcessingStatus75Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.PendingCancellation),nameof(ProcessingStatus75Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.Proprietary),nameof(ProcessingStatus75Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.CancellationRequested),nameof(ProcessingStatus75Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus75Choice.ModificationRequested),nameof(ProcessingStatus75Choice.ModificationRequested))]
    #endif
    [IsoId("_U2e7x-wMEeiazoAmcoGsBQ")]
    [DisplayName("Processing Status 75 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus75Choice_
    #else
    public abstract partial class ProcessingStatus75Choice_
    #endif
    {
    }
}
