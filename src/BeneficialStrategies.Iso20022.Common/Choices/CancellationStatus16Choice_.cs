// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus16Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationStatus16Choice.NoSpecifiedReason),
        nameof(CancellationStatus16Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus16Choice.Reason),
        nameof(CancellationStatus16Choice.Reason)
    )]
    [IsoId("_DHrD0Tw6EeW3QqUkIQtIUA")]
    [DisplayName("Cancellation Status 16 Choice")]
    public abstract record CancellationStatus16Choice_ { }
}
