// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus14Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus14Choice.NoSpecifiedReason),
        nameof(CancelledStatus14Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancelledStatus14Choice.Reason),
        nameof(CancelledStatus14Choice.Reason)
    )]
    [IsoId("_ce-515KQEeWHWpTQn1FFVg")]
    [DisplayName("Cancelled Status 14 Choice")]
    public abstract record CancelledStatus14Choice_ { }
}
