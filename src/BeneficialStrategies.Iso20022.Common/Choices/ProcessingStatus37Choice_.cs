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
    [KnownType(typeof(ProcessingStatus37Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus37Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus37Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus37Choice.Repair))]
    [KnownType(typeof(ProcessingStatus37Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus37Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus37Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus37Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus37Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus37Choice.AcknowledgedAccepted),nameof(ProcessingStatus37Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.PendingProcessing),nameof(ProcessingStatus37Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Rejected),nameof(ProcessingStatus37Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Repair),nameof(ProcessingStatus37Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Cancelled),nameof(ProcessingStatus37Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.PendingCancellation),nameof(ProcessingStatus37Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.Proprietary),nameof(ProcessingStatus37Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.CancellationRequested),nameof(ProcessingStatus37Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus37Choice.ModificationRequested),nameof(ProcessingStatus37Choice.ModificationRequested))]
    #endif
    [IsoId("_F0ajsSwuEeOEV5XHD-BKpw")]
    [DisplayName("Processing Status 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus37Choice_
    #else
    public abstract partial class ProcessingStatus37Choice_
    #endif
    {
    }
}
