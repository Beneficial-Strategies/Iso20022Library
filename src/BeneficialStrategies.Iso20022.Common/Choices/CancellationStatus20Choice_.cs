// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus20Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus20Choice.Reason))]
    [JsonDerivedType(typeof(CancellationStatus20Choice.NoSpecifiedReason),nameof(CancellationStatus20Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationStatus20Choice.Reason),nameof(CancellationStatus20Choice.Reason))]
    [IsoId("_6QE6NZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Status 20 Choice")]
    public abstract partial record CancellationStatus20Choice_
    {
    }
}
