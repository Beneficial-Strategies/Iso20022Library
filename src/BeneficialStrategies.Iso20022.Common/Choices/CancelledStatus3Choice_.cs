// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus3Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus3Choice.NoSpecifiedReason),
        nameof(CancelledStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(CancelledStatus3Choice.Reason), nameof(CancelledStatus3Choice.Reason))]
    [IsoId("_V4EH7eJxEd-Q6MzBzY5WkA")]
    [DisplayName("Cancelled Status 3 Choice")]
    public abstract record CancelledStatus3Choice_ { }
}
