// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus21Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus21Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus21Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus21Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus21Choice.Reason),
        nameof(AcknowledgedAcceptedStatus21Choice.Reason)
    )]
    [IsoId("_gwUucTnvEeWfSKvvZlhRKg")]
    [DisplayName("Acknowledged Accepted Status 21 Choice")]
    public abstract record AcknowledgedAcceptedStatus21Choice_ { }
}
