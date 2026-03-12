// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason for an in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatusReason4Choice.NoSpecifiedReason))]
    [KnownType(typeof(InRepairStatusReason4Choice.ReasonDetails))]
    [JsonDerivedType(typeof(InRepairStatusReason4Choice.NoSpecifiedReason),nameof(InRepairStatusReason4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(InRepairStatusReason4Choice.ReasonDetails),nameof(InRepairStatusReason4Choice.ReasonDetails))]
    [IsoId("_BRBdEUHqEea8I67lh6qdSQ")]
    [DisplayName("In Repair Status Reason 4 Choice")]
    public abstract partial record InRepairStatusReason4Choice_
    {
    }
}
