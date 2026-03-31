// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason4Choice.Code))]
    [KnownType(typeof(RejectedReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason4Choice.Code), nameof(RejectedReason4Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason4Choice.Proprietary),
        nameof(RejectedReason4Choice.Proprietary)
    )]
    [IsoId("_46qd0R6qEeODgY9qxg6TFA")]
    [DisplayName("Rejected Reason 4 Choice")]
    public abstract record RejectedReason4Choice_ { }
}
