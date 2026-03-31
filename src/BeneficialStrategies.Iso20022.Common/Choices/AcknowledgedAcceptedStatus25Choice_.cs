// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus25Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus25Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus25Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus25Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus25Choice.Reason),
        nameof(AcknowledgedAcceptedStatus25Choice.Reason)
    )]
    [IsoId("_5SFngZNLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledged Accepted Status 25 Choice")]
    public abstract record AcknowledgedAcceptedStatus25Choice_ { }
}
