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
    [KnownType(typeof(ProcessingStatus21Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus21Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus21Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus21Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus21Choice.Repair))]
    [KnownType(typeof(ProcessingStatus21Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus21Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus21Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus21Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus21Choice.PendingCancellation),nameof(ProcessingStatus21Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.AcknowledgedAccepted),nameof(ProcessingStatus21Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.PendingProcessing),nameof(ProcessingStatus21Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.Rejected),nameof(ProcessingStatus21Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.Repair),nameof(ProcessingStatus21Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.Cancelled),nameof(ProcessingStatus21Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.Proprietary),nameof(ProcessingStatus21Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.CancellationRequested),nameof(ProcessingStatus21Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus21Choice.ModificationRequested),nameof(ProcessingStatus21Choice.ModificationRequested))]
    #endif
    [IsoId("_yyd8Qf5WEeCtrO5qCU90cA")]
    [DisplayName("Processing Status 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus21Choice_
    #else
    public abstract partial class ProcessingStatus21Choice_
    #endif
    {
    }
}
