// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction/Request has been cancelled.
    /// </summary>
    [KnownType(typeof(CancellationStatus30Choice.Cancelled))]
    [KnownType(typeof(CancellationStatus30Choice.Processed))]
    [KnownType(typeof(CancellationStatus30Choice.Pending))]
    [KnownType(typeof(CancellationStatus30Choice.Rejected))]
    [KnownType(typeof(CancellationStatus30Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Cancelled),nameof(CancellationStatus30Choice.Cancelled))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Processed),nameof(CancellationStatus30Choice.Processed))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Pending),nameof(CancellationStatus30Choice.Pending))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Rejected),nameof(CancellationStatus30Choice.Rejected))]
    [JsonDerivedType(typeof(CancellationStatus30Choice.Proprietary),nameof(CancellationStatus30Choice.Proprietary))]
    [IsoId("_TpwpcRIwEeydmIVkS03esw")]
    [DisplayName("Cancellation Status 30 Choice")]
    public abstract partial record CancellationStatus30Choice_
    {
    }
}
