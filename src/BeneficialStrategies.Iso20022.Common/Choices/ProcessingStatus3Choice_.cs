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
    [KnownType(typeof(ProcessingStatus3Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus3Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus3Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus3Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus3Choice.Repair))]
    [KnownType(typeof(ProcessingStatus3Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus3Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus3Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus3Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus3Choice.PendingCancellation),nameof(ProcessingStatus3Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.AcknowledgedAccepted),nameof(ProcessingStatus3Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.PendingProcessing),nameof(ProcessingStatus3Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Rejected),nameof(ProcessingStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Repair),nameof(ProcessingStatus3Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Cancelled),nameof(ProcessingStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.Proprietary),nameof(ProcessingStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.CancellationRequested),nameof(ProcessingStatus3Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus3Choice.ModificationRequested),nameof(ProcessingStatus3Choice.ModificationRequested))]
    #endif
    [IsoId("_UVy5ltp-Ed-ak6NoX_4Aeg_-1628943211")]
    [DisplayName("Processing Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus3Choice_
    #else
    public abstract partial class ProcessingStatus3Choice_
    #endif
    {
    }
}
