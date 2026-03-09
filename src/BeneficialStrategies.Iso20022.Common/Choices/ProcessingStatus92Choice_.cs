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
    [KnownType(typeof(ProcessingStatus92Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus92Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus92Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus92Choice.Repair))]
    [KnownType(typeof(ProcessingStatus92Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus92Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus92Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus92Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus92Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus92Choice.AcknowledgedAccepted),nameof(ProcessingStatus92Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.PendingProcessing),nameof(ProcessingStatus92Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.Rejected),nameof(ProcessingStatus92Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.Repair),nameof(ProcessingStatus92Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.Cancelled),nameof(ProcessingStatus92Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.PendingCancellation),nameof(ProcessingStatus92Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.Proprietary),nameof(ProcessingStatus92Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.CancellationRequested),nameof(ProcessingStatus92Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus92Choice.ModificationRequested),nameof(ProcessingStatus92Choice.ModificationRequested))]
    #endif
    [IsoId("_dsyaRji8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 92 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus92Choice_
    #else
    public abstract partial class ProcessingStatus92Choice_
    #endif
    {
    }
}
