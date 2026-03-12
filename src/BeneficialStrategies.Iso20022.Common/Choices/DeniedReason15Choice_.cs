// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason15Choice.Code))]
    [KnownType(typeof(DeniedReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason15Choice.Code),nameof(DeniedReason15Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason15Choice.Proprietary),nameof(DeniedReason15Choice.Proprietary))]
    [IsoId("__qgcwTq1EeWyoP0PbocV1Q")]
    [DisplayName("Denied Reason 15 Choice")]
    public abstract partial record DeniedReason15Choice_
    {
    }
}
