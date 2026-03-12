// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus15Choice.Reason))]
    [JsonDerivedType(typeof(CancellationStatus15Choice.NoSpecifiedReason),nameof(CancellationStatus15Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationStatus15Choice.Reason),nameof(CancellationStatus15Choice.Reason))]
    [IsoId("_LuSEQTs9EeWRTLSN0i0tng")]
    [DisplayName("Cancellation Status 15 Choice")]
    public abstract partial record CancellationStatus15Choice_
    {
    }
}
