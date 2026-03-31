// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus8Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationStatus8Choice.NoSpecifiedReason),
        nameof(CancellationStatus8Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus8Choice.Reason),
        nameof(CancellationStatus8Choice.Reason)
    )]
    [IsoId("_XGMNwf7rEeCvPoRGOxRobQ")]
    [DisplayName("Cancellation Status 8 Choice")]
    public abstract record CancellationStatus8Choice_ { }
}
