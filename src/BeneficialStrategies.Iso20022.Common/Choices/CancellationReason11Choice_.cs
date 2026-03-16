// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationReason11Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationReason11Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationReason11Choice.NoSpecifiedReason),
        nameof(CancellationReason11Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationReason11Choice.Reason),
        nameof(CancellationReason11Choice.Reason)
    )]
    [IsoId("_A0Fk0NokEeC60axPepSq7g_1353519465")]
    [DisplayName("Cancellation Reason 11 Choice")]
    public abstract record CancellationReason11Choice_ { }
}
