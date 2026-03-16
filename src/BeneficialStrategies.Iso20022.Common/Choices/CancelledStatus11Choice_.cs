// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus11Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus11Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus11Choice.NoSpecifiedReason),
        nameof(CancelledStatus11Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancelledStatus11Choice.Reason),
        nameof(CancelledStatus11Choice.Reason)
    )]
    [IsoId("_8rhqC0GWEeWqy4niLuXETA")]
    [DisplayName("Cancelled Status 11 Choice")]
    public abstract record CancelledStatus11Choice_ { }
}
