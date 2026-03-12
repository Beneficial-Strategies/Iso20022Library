// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatusReason5Choice.Code))]
    [KnownType(typeof(InRepairStatusReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(InRepairStatusReason5Choice.Code),nameof(InRepairStatusReason5Choice.Code))]
    [JsonDerivedType(typeof(InRepairStatusReason5Choice.Proprietary),nameof(InRepairStatusReason5Choice.Proprietary))]
    [IsoId("_PjtfkUHqEea8I67lh6qdSQ")]
    [DisplayName("In Repair Status Reason 5 Choice")]
    public abstract partial record InRepairStatusReason5Choice_
    {
    }
}
