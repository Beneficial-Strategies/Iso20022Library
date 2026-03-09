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
    [KnownType(typeof(ProcessingStatus1Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus1Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus1Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus1Choice.Repair))]
    [KnownType(typeof(ProcessingStatus1Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus1Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus1Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus1Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus1Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus1Choice.AcknowledgedAccepted),nameof(ProcessingStatus1Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.PendingProcessing),nameof(ProcessingStatus1Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.Rejected),nameof(ProcessingStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.Repair),nameof(ProcessingStatus1Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.Cancelled),nameof(ProcessingStatus1Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.PendingCancellation),nameof(ProcessingStatus1Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.Proprietary),nameof(ProcessingStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.CancellationRequested),nameof(ProcessingStatus1Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus1Choice.ModificationRequested),nameof(ProcessingStatus1Choice.ModificationRequested))]
    #endif
    [IsoId("_UVfXktp-Ed-ak6NoX_4Aeg_1256986454")]
    [DisplayName("Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus1Choice_
    #else
    public abstract partial class ProcessingStatus1Choice_
    #endif
    {
    }
}
