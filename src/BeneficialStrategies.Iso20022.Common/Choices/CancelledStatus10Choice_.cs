// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancelledStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus10Choice.Reason))]
    [JsonDerivedType(typeof(CancelledStatus10Choice.NoSpecifiedReason),nameof(CancelledStatus10Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledStatus10Choice.Reason),nameof(CancelledStatus10Choice.Reason))]
    [IsoId("_1k2bQTt5EeW638lNyHKv7A")]
    [DisplayName("Cancelled Status 10 Choice")]
    public abstract partial record CancelledStatus10Choice_
    {
    }
}
