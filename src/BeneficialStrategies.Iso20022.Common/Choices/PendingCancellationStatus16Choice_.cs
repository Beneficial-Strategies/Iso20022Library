// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Cancellation Status16Choice.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus16Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus16Choice.NoSpecifiedReason),nameof(PendingCancellationStatus16Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus16Choice.Reason),nameof(PendingCancellationStatus16Choice.Reason))]
    [IsoId("_j2GBsZt3Ee-wQIOX0djF2w")]
    [DisplayName("Pending Cancellation Status16Choice")]
    public abstract partial record PendingCancellationStatus16Choice_
    {
    }
}
