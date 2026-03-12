// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [KnownType(typeof(ProcessingStatus82Choice.Processed))]
    [KnownType(typeof(ProcessingStatus82Choice.Future))]
    [KnownType(typeof(ProcessingStatus82Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus82Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus82Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus82Choice.CancellationRequest))]
    [KnownType(typeof(ProcessingStatus82Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Processed),nameof(ProcessingStatus82Choice.Processed))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Future),nameof(ProcessingStatus82Choice.Future))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Rejected),nameof(ProcessingStatus82Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Cancelled),nameof(ProcessingStatus82Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.PendingCancellation),nameof(ProcessingStatus82Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.CancellationRequest),nameof(ProcessingStatus82Choice.CancellationRequest))]
    [JsonDerivedType(typeof(ProcessingStatus82Choice.Proprietary),nameof(ProcessingStatus82Choice.Proprietary))]
    [IsoId("_FNlTwRIwEeydmIVkS03esw")]
    [DisplayName("Processing Status 82 Choice")]
    public abstract partial record ProcessingStatus82Choice_
    {
    }
}
