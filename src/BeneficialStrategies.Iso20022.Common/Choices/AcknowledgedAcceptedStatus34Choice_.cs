// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(AcknowledgedAcceptedStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcknowledgedAcceptedStatus34Choice.Reason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus34Choice.NoSpecifiedReason), nameof(AcknowledgedAcceptedStatus34Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(AcknowledgedAcceptedStatus34Choice.Reason), nameof(AcknowledgedAcceptedStatus34Choice.Reason))]
    [IsoId("_XHw_IY5bEfC_4ZEXsY0Xyg")]
    [DisplayName("AcknowledgedAcceptedStatus34Choice")]
    public abstract record AcknowledgedAcceptedStatus34Choice_ { }
}
