// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the rejected reason.
    /// </summary>
    [KnownType(typeof(RejectedReason15Choice.Code))]
    [KnownType(typeof(RejectedReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason15Choice.Code), nameof(RejectedReason15Choice.Code))]
    [JsonDerivedType(
        typeof(RejectedReason15Choice.Proprietary),
        nameof(RejectedReason15Choice.Proprietary)
    )]
    [IsoId("_GV8iMSY3EeW_ZNn8gbfY7Q")]
    [DisplayName("Rejected Reason 15 Choice")]
    public abstract record RejectedReason15Choice_ { }
}
