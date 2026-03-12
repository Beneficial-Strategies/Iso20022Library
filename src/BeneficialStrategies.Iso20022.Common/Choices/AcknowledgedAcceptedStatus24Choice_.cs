// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus24Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus24Choice.Reason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus24Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus24Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus24Choice.Reason),nameof(AcknowledgedAcceptedStatus24Choice.Reason))]
    [IsoId("_OcXnITq5EeWyoP0PbocV1Q")]
    [DisplayName("Acknowledged Accepted Status 24 Choice")]
    public abstract partial record AcknowledgedAcceptedStatus24Choice_
    {
    }
}
