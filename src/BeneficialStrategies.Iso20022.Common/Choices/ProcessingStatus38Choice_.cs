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
    [KnownType(typeof(ProcessingStatus38Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus38Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus38Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus38Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus38Choice.Repair))]
    [KnownType(typeof(ProcessingStatus38Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus38Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus38Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus38Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus38Choice.PendingCancellation),nameof(ProcessingStatus38Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.AcknowledgedAccepted),nameof(ProcessingStatus38Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.PendingProcessing),nameof(ProcessingStatus38Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Rejected),nameof(ProcessingStatus38Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Repair),nameof(ProcessingStatus38Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Cancelled),nameof(ProcessingStatus38Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.Proprietary),nameof(ProcessingStatus38Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.CancellationRequested),nameof(ProcessingStatus38Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus38Choice.ModificationRequested),nameof(ProcessingStatus38Choice.ModificationRequested))]
    #endif
    [IsoId("_tHuVkSwvEeOEV5XHD-BKpw")]
    [DisplayName("Processing Status 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus38Choice_
    #else
    public abstract partial class ProcessingStatus38Choice_
    #endif
    {
    }
}
