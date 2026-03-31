// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus10Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus10Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus10Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus10Choice.Reason),
        nameof(AcknowledgedAcceptedStatus10Choice.Reason)
    )]
    [IsoId("_fHQhV_7rEeCvPoRGOxRobQ")]
    [DisplayName("Acknowledged Accepted Status 10 Choice")]
    public abstract record AcknowledgedAcceptedStatus10Choice_ { }
}
