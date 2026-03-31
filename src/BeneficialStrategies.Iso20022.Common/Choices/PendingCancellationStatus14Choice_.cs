// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Cancellation Status14Choice.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus14Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingCancellationStatus14Choice.NoSpecifiedReason),
        nameof(PendingCancellationStatus14Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationStatus14Choice.Reason),
        nameof(PendingCancellationStatus14Choice.Reason)
    )]
    [IsoId("_A_n8MYYTEe-9jM3-w7OB3g")]
    [DisplayName("Pending Cancellation Status14Choice")]
    public abstract record PendingCancellationStatus14Choice_ { }
}
