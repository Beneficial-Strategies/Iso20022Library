// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a suspended status.
    /// </summary>
    [KnownType(typeof(SuspendedStatusReason5Choice.Code))]
    [KnownType(typeof(SuspendedStatusReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(SuspendedStatusReason5Choice.Code),nameof(SuspendedStatusReason5Choice.Code))]
    [JsonDerivedType(typeof(SuspendedStatusReason5Choice.Proprietary),nameof(SuspendedStatusReason5Choice.Proprietary))]
    [IsoId("_ocV_UUHlEea8I67lh6qdSQ")]
    [DisplayName("Suspended Status Reason 5 Choice")]
    public abstract partial record SuspendedStatusReason5Choice_
    {
    }
}
