// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus80Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus80Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus80Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus80Choice.Repair))]
    [KnownType(typeof(ProcessingStatus80Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus80Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus80Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus80Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus80Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.AcknowledgedAccepted),nameof(ProcessingStatus80Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.PendingProcessing),nameof(ProcessingStatus80Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.Rejected),nameof(ProcessingStatus80Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.Repair),nameof(ProcessingStatus80Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.Cancelled),nameof(ProcessingStatus80Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.PendingCancellation),nameof(ProcessingStatus80Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.Proprietary),nameof(ProcessingStatus80Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.CancellationRequested),nameof(ProcessingStatus80Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus80Choice.ModificationRequested),nameof(ProcessingStatus80Choice.ModificationRequested))]
    [IsoId("_6T29gQpJEeup4r-PFG2T5Q")]
    [DisplayName("Processing Status 80 Choice")]
    public abstract partial record ProcessingStatus80Choice_
    {
    }
}
