// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus9Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus9Choice.Reason))]
    [JsonDerivedType(typeof(CancellationStatus9Choice.NoSpecifiedReason),nameof(CancellationStatus9Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationStatus9Choice.Reason),nameof(CancellationStatus9Choice.Reason))]
    [IsoId("_BFuKwf7sEeCvPoRGOxRobQ")]
    [DisplayName("Cancellation Status 9 Choice")]
    public abstract partial record CancellationStatus9Choice_
    {
    }
}
