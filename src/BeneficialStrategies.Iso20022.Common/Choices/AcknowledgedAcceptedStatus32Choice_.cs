// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus32Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus32Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus32Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus32Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus32Choice.Reason),
        nameof(AcknowledgedAcceptedStatus32Choice.Reason)
    )]
    [IsoId("_K3A-kekHEemm4qhb2yFPOw")]
    [DisplayName("Acknowledged Accepted Status 32 Choice")]
    public abstract record AcknowledgedAcceptedStatus32Choice_ { }
}
