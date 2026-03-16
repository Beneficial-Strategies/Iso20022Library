// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Cancellation Status13Choice.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus13Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingCancellationStatus13Choice.NoSpecifiedReason),
        nameof(PendingCancellationStatus13Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationStatus13Choice.Reason),
        nameof(PendingCancellationStatus13Choice.Reason)
    )]
    [IsoId("_C8HI8YYREe-9jM3-w7OB3g")]
    [DisplayName("Pending Cancellation Status13Choice")]
    public abstract record PendingCancellationStatus13Choice_ { }
}
