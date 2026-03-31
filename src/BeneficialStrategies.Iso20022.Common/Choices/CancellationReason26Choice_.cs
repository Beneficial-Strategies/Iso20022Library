// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason26Choice.Code))]
    [KnownType(typeof(CancellationReason26Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason26Choice.Code),
        nameof(CancellationReason26Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason26Choice.Proprietary),
        nameof(CancellationReason26Choice.Proprietary)
    )]
    [IsoId("_6HWbcZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Reason 26 Choice")]
    public abstract record CancellationReason26Choice_ { }
}
