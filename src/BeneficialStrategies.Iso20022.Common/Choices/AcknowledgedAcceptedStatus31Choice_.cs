// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus31Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus31Choice.Reason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus31Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus31Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus31Choice.Reason),nameof(AcknowledgedAcceptedStatus31Choice.Reason))]
    [IsoId("_6QETK5NLEeWGlc8L7oPDIg")]
    [DisplayName("Acknowledged Accepted Status 31 Choice")]
    public abstract partial record AcknowledgedAcceptedStatus31Choice_
    {
    }
}
