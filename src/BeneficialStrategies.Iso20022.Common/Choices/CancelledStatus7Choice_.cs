// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus7Choice.Reason))]
    [JsonDerivedType(
        typeof(CancelledStatus7Choice.NoSpecifiedReason),
        nameof(CancelledStatus7Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(CancelledStatus7Choice.Reason), nameof(CancelledStatus7Choice.Reason))]
    [IsoId("_cNU2gVhlEeSsH9MSoogb7Q")]
    [DisplayName("Cancelled Status 7 Choice")]
    public abstract record CancelledStatus7Choice_ { }
}
