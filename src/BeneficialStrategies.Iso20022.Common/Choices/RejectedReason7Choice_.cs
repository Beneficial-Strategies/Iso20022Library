// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason7Choice.Code))]
    [KnownType(typeof(RejectedReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason7Choice.Code), nameof(RejectedReason7Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason7Choice.Proprietary),
        nameof(RejectedReason7Choice.Proprietary)
    )]
    [IsoId("_sv4bRlj7EeOgwYxfAV02bg")]
    [DisplayName("Rejected Reason 7 Choice")]
    public abstract record RejectedReason7Choice_ { }
}
