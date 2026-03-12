// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus7Choice.Reason))]
    [JsonDerivedType(typeof(CancellationStatus7Choice.NoSpecifiedReason),nameof(CancellationStatus7Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationStatus7Choice.Reason),nameof(CancellationStatus7Choice.Reason))]
    [IsoId("_nR4Ikf5DEeClUvPNHKL9Zw")]
    [DisplayName("Cancellation Status 7 Choice")]
    public abstract partial record CancellationStatus7Choice_
    {
    }
}
