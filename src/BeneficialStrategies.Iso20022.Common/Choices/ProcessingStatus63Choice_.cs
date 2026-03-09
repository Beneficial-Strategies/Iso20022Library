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
    [KnownType(typeof(ProcessingStatus63Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus63Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus63Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus63Choice.Repair))]
    [KnownType(typeof(ProcessingStatus63Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus63Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus63Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus63Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus63Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus63Choice.AcknowledgedAccepted),nameof(ProcessingStatus63Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.PendingProcessing),nameof(ProcessingStatus63Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.Rejected),nameof(ProcessingStatus63Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.Repair),nameof(ProcessingStatus63Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.Cancelled),nameof(ProcessingStatus63Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.PendingCancellation),nameof(ProcessingStatus63Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.Proprietary),nameof(ProcessingStatus63Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.CancellationRequested),nameof(ProcessingStatus63Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus63Choice.ModificationRequested),nameof(ProcessingStatus63Choice.ModificationRequested))]
    #endif
    [IsoId("_8Nnkf5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 63 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus63Choice_
    #else
    public abstract partial class ProcessingStatus63Choice_
    #endif
    {
    }
}
