// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus17Choice.Reason))]
    [JsonDerivedType(typeof(CancellationStatus17Choice.NoSpecifiedReason),nameof(CancellationStatus17Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationStatus17Choice.Reason),nameof(CancellationStatus17Choice.Reason))]
    [IsoId("_5SFnM5NLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Status 17 Choice")]
    public abstract partial record CancellationStatus17Choice_
    {
    }
}
