// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus33Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus33Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus33Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus33Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus33Choice.Reason),
        nameof(AcknowledgedAcceptedStatus33Choice.Reason)
    )]
    [IsoId("_HqnHhZwZEeqtp-LOti013g")]
    [DisplayName("Acknowledged Accepted Status 33 Choice")]
    public abstract record AcknowledgedAcceptedStatus33Choice_ { }
}
