// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason8Choice.Code))]
    [KnownType(typeof(FailingReason8Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason8Choice.Code),nameof(FailingReason8Choice.Code))]
    [JsonDerivedType(typeof(FailingReason8Choice.Proprietary),nameof(FailingReason8Choice.Proprietary))]
    [IsoId("_4D4UUTqOEeWyoP0PbocV1Q")]
    [DisplayName("Failing Reason 8 Choice")]
    public abstract partial record FailingReason8Choice_
    {
    }
}
