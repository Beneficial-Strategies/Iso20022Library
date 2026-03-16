// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus25Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus25Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationStatus25Choice.NoSpecifiedReason),
        nameof(CancellationStatus25Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus25Choice.Reason),
        nameof(CancellationStatus25Choice.Reason)
    )]
    [IsoId("_65Na5_fUEeiNZp_PtLohLw")]
    [DisplayName("Cancellation Status 25 Choice")]
    public abstract record CancellationStatus25Choice_ { }
}
