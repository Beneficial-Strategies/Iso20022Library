// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus18Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationStatus18Choice.NoSpecifiedReason),
        nameof(CancellationStatus18Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus18Choice.Reason),
        nameof(CancellationStatus18Choice.Reason)
    )]
    [IsoId("_6BHQh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Status 18 Choice")]
    public abstract record CancellationStatus18Choice_ { }
}
