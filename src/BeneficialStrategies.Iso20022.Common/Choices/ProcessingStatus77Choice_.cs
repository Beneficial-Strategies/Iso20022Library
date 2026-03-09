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
    [KnownType(typeof(ProcessingStatus77Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus77Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus77Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus77Choice.Repair))]
    [KnownType(typeof(ProcessingStatus77Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus77Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus77Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus77Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus77Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus77Choice.AcknowledgedAccepted),nameof(ProcessingStatus77Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.PendingProcessing),nameof(ProcessingStatus77Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Rejected),nameof(ProcessingStatus77Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Repair),nameof(ProcessingStatus77Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Cancelled),nameof(ProcessingStatus77Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.PendingCancellation),nameof(ProcessingStatus77Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.Proprietary),nameof(ProcessingStatus77Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.CancellationRequested),nameof(ProcessingStatus77Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus77Choice.ModificationRequested),nameof(ProcessingStatus77Choice.ModificationRequested))]
    #endif
    [IsoId("_AYE5i_fZEeiNZp_PtLohLw")]
    [DisplayName("Processing Status 77 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus77Choice_
    #else
    public abstract partial class ProcessingStatus77Choice_
    #endif
    {
    }
}
