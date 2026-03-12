// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus7Choice.Reason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus7Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus7Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus7Choice.Reason),nameof(AcknowledgedAcceptedStatus7Choice.Reason))]
    [IsoId("_y9mO8f7qEeCvPoRGOxRobQ")]
    [DisplayName("Acknowledged Accepted Status 7 Choice")]
    public abstract partial record AcknowledgedAcceptedStatus7Choice_
    {
    }
}
