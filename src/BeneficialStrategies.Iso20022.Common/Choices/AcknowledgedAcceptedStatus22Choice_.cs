// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus22Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus22Choice.Reason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus22Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus22Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus22Choice.Reason),nameof(AcknowledgedAcceptedStatus22Choice.Reason))]
    [IsoId("_ThE_kTqrEeWyoP0PbocV1Q")]
    [DisplayName("Acknowledged Accepted Status 22 Choice")]
    public abstract partial record AcknowledgedAcceptedStatus22Choice_
    {
    }
}
