// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus23Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus23Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus23Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus23Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus23Choice.Reason),
        nameof(AcknowledgedAcceptedStatus23Choice.Reason)
    )]
    [IsoId("_XhBbUTq1EeWyoP0PbocV1Q")]
    [DisplayName("Acknowledged Accepted Status 23 Choice")]
    public abstract record AcknowledgedAcceptedStatus23Choice_ { }
}
