// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus14Choice.Reason))]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus14Choice.NoSpecifiedReason),
        nameof(AcknowledgedAcceptedStatus14Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(AcknowledgedAcceptedStatus14Choice.Reason),
        nameof(AcknowledgedAcceptedStatus14Choice.Reason)
    )]
    [IsoId("_0jYTAQlIEeGATtfOBToyew_1285673408")]
    [DisplayName("Acknowledged Accepted Status 14 Choice")]
    public abstract record AcknowledgedAcceptedStatus14Choice_ { }
}
