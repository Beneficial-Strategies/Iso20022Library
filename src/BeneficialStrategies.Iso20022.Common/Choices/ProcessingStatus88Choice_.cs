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
    /// Choice of formats for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus88Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus88Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus88Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus88Choice.Repair))]
    [KnownType(typeof(ProcessingStatus88Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus88Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus88Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus88Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus88Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus88Choice.AcknowledgedAccepted),nameof(ProcessingStatus88Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.PendingProcessing),nameof(ProcessingStatus88Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.Rejected),nameof(ProcessingStatus88Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.Repair),nameof(ProcessingStatus88Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.Cancelled),nameof(ProcessingStatus88Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.PendingCancellation),nameof(ProcessingStatus88Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.Proprietary),nameof(ProcessingStatus88Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.CancellationRequested),nameof(ProcessingStatus88Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus88Choice.ModificationRequested),nameof(ProcessingStatus88Choice.ModificationRequested))]
    #endif
    [IsoId("_g5IR4StXEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 88 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus88Choice_
    #else
    public abstract partial class ProcessingStatus88Choice_
    #endif
    {
    }
}
