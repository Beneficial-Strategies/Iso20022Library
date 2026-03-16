// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cancelled Status17Choice.
    /// </summary>
    [KnownType(typeof(CancelledStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus17Choice.Reason))]
    [JsonDerivedType(typeof(CancelledStatus17Choice.NoSpecifiedReason),nameof(CancelledStatus17Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancelledStatus17Choice.Reason),nameof(CancelledStatus17Choice.Reason))]
    [IsoId("_uMRd8ZznEe-DHYbvdRjdbA")]
    [DisplayName("Cancelled Status17Choice")]
    public abstract partial record CancelledStatus17Choice_
    {
    }
}
