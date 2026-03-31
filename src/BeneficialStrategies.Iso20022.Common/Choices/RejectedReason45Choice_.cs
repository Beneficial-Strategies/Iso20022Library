// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason45Choice.Code))]
    [KnownType(typeof(RejectedReason45Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason45Choice.Code), nameof(RejectedReason45Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason45Choice.Proprietary),
        nameof(RejectedReason45Choice.Proprietary)
    )]
    [IsoId("_WtjBE-ijEeuLe8v4JEtDDg")]
    [DisplayName("Rejected Reason 45 Choice")]
    public abstract record RejectedReason45Choice_ { }
}
