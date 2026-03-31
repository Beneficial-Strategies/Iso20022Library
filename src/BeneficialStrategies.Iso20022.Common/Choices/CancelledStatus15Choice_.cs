// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus15Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus15Choice.NoSpecifiedReason),
        nameof(CancelledStatus15Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancelledStatus15Choice.Reason),
        nameof(CancelledStatus15Choice.Reason)
    )]
    [IsoId("_cgnRl5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cancelled Status 15 Choice")]
    public abstract record CancelledStatus15Choice_ { }
}
