// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Cancellation Status15Choice.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus15Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus15Choice.NoSpecifiedReason),nameof(PendingCancellationStatus15Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus15Choice.Reason),nameof(PendingCancellationStatus15Choice.Reason))]
    [IsoId("_jhlwhZt3Ee-wQIOX0djF2w")]
    [DisplayName("Pending Cancellation Status15Choice")]
    public abstract partial record PendingCancellationStatus15Choice_
    {
    }
}
