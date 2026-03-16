// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus3Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus3Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus3Choice.Reason),
        nameof(AcknowledgedAcceptedStatus3Choice.Reason)
    )]
    [IsoId("_UZOBBNp-Ed-ak6NoX_4Aeg_331394466")]
    [DisplayName("Acknowledged Accepted Status 3 Choice")]
    public abstract record AcknowledgedAcceptedStatus3Choice_ { }
}
