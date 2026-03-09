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
    [KnownType(typeof(ProcessingStatus76Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus76Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus76Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus76Choice.Repair))]
    [KnownType(typeof(ProcessingStatus76Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus76Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus76Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus76Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus76Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus76Choice.AcknowledgedAccepted),nameof(ProcessingStatus76Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.PendingProcessing),nameof(ProcessingStatus76Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.Rejected),nameof(ProcessingStatus76Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.Repair),nameof(ProcessingStatus76Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.Cancelled),nameof(ProcessingStatus76Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.PendingCancellation),nameof(ProcessingStatus76Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.Proprietary),nameof(ProcessingStatus76Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.CancellationRequested),nameof(ProcessingStatus76Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus76Choice.ModificationRequested),nameof(ProcessingStatus76Choice.ModificationRequested))]
    #endif
    [IsoId("_ukeL1ffXEeiNZp_PtLohLw")]
    [DisplayName("Processing Status 76 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus76Choice_
    #else
    public abstract partial class ProcessingStatus76Choice_
    #endif
    {
    }
}
