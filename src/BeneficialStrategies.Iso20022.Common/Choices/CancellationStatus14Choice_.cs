// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus14Choice.Reason))]
    [JsonDerivedType(typeof(CancellationStatus14Choice.NoSpecifiedReason),nameof(CancellationStatus14Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationStatus14Choice.Reason),nameof(CancellationStatus14Choice.Reason))]
    [IsoId("_hlFozznuEeWfSKvvZlhRKg")]
    [DisplayName("Cancellation Status 14 Choice")]
    public abstract partial record CancellationStatus14Choice_
    {
    }
}
