// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus27Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus27Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus27Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus27Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus27Choice.Reason),
        nameof(AcknowledgedAcceptedStatus27Choice.Reason)
    )]
    [IsoId("_6BK6w5NLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledged Accepted Status 27 Choice")]
    public abstract record AcknowledgedAcceptedStatus27Choice_ { }
}
