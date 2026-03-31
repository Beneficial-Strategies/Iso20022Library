// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of a received status.
    /// </summary>
    [KnownType(typeof(ReceivedReason2Choice.Code))]
    [KnownType(typeof(ReceivedReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(ReceivedReason2Choice.Code), nameof(ReceivedReason2Choice.Code))]
    [JsonDerivedType(
        typeof(ReceivedReason2Choice.Proprietary),
        nameof(ReceivedReason2Choice.Proprietary)
    )]
    [IsoId("_2y5Nxlj6EeOgwYxfAV02bg")]
    [DisplayName("Received Reason 2 Choice")]
    public abstract record ReceivedReason2Choice_ { }
}
