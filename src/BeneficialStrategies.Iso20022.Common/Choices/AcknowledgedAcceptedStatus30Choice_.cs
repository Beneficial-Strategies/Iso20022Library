// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus30Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus30Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus30Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus30Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus30Choice.Reason),
        nameof(AcknowledgedAcceptedStatus30Choice.Reason)
    )]
    [IsoId("_6QCdXZNLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledged Accepted Status 30 Choice")]
    public abstract record AcknowledgedAcceptedStatus30Choice_ { }
}
