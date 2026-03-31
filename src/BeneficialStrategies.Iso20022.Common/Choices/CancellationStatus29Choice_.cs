// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction/Request has been cancelled.
    /// </summary>
    [KnownType(typeof(CancellationStatus29Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus29Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationStatus29Choice.NoSpecifiedReason),
        nameof(CancellationStatus29Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus29Choice.Reason),
        nameof(CancellationStatus29Choice.Reason)
    )]
    [IsoId("_u2DukOBEEeiVRbNQx5-Vhg")]
    [DisplayName("Cancellation Status 29 Choice")]
    public abstract record CancellationStatus29Choice_ { }
}
