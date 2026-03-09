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
    [KnownType(typeof(ProcessingStatus81Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus81Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus81Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus81Choice.Repair))]
    [KnownType(typeof(ProcessingStatus81Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus81Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus81Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus81Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus81Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus81Choice.AcknowledgedAccepted),nameof(ProcessingStatus81Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.PendingProcessing),nameof(ProcessingStatus81Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.Rejected),nameof(ProcessingStatus81Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.Repair),nameof(ProcessingStatus81Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.Cancelled),nameof(ProcessingStatus81Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.PendingCancellation),nameof(ProcessingStatus81Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.Proprietary),nameof(ProcessingStatus81Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.CancellationRequested),nameof(ProcessingStatus81Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus81Choice.ModificationRequested),nameof(ProcessingStatus81Choice.ModificationRequested))]
    #endif
    [IsoId("_qTGP6yAdEeuyDZ-ukt4YRg")]
    [DisplayName("Processing Status 81 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus81Choice_
    #else
    public abstract partial class ProcessingStatus81Choice_
    #endif
    {
    }
}
