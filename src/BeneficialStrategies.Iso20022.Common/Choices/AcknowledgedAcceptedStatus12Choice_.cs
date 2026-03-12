// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus12Choice.Reason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus12Choice.NoSpecifiedReason),nameof(AcknowledgedAcceptedStatus12Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus12Choice.Reason),nameof(AcknowledgedAcceptedStatus12Choice.Reason))]
    [IsoId("_2zEPV_7rEeCvPoRGOxRobQ")]
    [DisplayName("Acknowledged Accepted Status 12 Choice")]
    public abstract partial record AcknowledgedAcceptedStatus12Choice_
    {
    }
}
