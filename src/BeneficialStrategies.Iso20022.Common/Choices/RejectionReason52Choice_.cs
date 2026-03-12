// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection reason.
    /// </summary>
    [KnownType(typeof(RejectionReason52Choice.Code))]
    [KnownType(typeof(RejectionReason52Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionReason52Choice.Code),nameof(RejectionReason52Choice.Code))]
    [JsonDerivedType(typeof(RejectionReason52Choice.Proprietary),nameof(RejectionReason52Choice.Proprietary))]
    [IsoId("_yZlhSgarEe2phaVG0lYKTw")]
    [DisplayName("Rejection Reason 52 Choice")]
    public abstract partial record RejectionReason52Choice_
    {
    }
}
