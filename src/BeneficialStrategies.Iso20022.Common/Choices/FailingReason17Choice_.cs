// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason17Choice.Code))]
    [KnownType(typeof(FailingReason17Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason17Choice.Code),nameof(FailingReason17Choice.Code))]
    [JsonDerivedType(typeof(FailingReason17Choice.Proprietary),nameof(FailingReason17Choice.Proprietary))]
    [IsoId("_f99yLTi8Eeydid5dcNPKvg")]
    [DisplayName("Failing Reason 17 Choice")]
    public abstract partial record FailingReason17Choice_
    {
    }
}
