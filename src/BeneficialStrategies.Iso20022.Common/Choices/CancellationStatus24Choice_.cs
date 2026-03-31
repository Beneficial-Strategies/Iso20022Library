// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus24Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus24Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationStatus24Choice.NoSpecifiedReason),
        nameof(CancellationStatus24Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus24Choice.Reason),
        nameof(CancellationStatus24Choice.Reason)
    )]
    [IsoId("_GcCjM9B7EeihG9bKfarOOA")]
    [DisplayName("Cancellation Status 24 Choice")]
    public abstract record CancellationStatus24Choice_ { }
}
