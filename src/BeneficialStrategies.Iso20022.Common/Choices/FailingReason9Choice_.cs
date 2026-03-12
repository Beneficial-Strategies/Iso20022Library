// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason9Choice.Code))]
    [KnownType(typeof(FailingReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason9Choice.Code),nameof(FailingReason9Choice.Code))]
    [JsonDerivedType(typeof(FailingReason9Choice.Proprietary),nameof(FailingReason9Choice.Proprietary))]
    [IsoId("_93AbkTqxEeWyoP0PbocV1Q")]
    [DisplayName("Failing Reason 9 Choice")]
    public abstract partial record FailingReason9Choice_
    {
    }
}
