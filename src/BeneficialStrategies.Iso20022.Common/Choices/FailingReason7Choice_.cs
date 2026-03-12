// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason7Choice.Code))]
    [KnownType(typeof(FailingReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason7Choice.Code),nameof(FailingReason7Choice.Code))]
    [JsonDerivedType(typeof(FailingReason7Choice.Proprietary),nameof(FailingReason7Choice.Proprietary))]
    [IsoId("_26U30Tp5EeWVrPy0StzzSg")]
    [DisplayName("Failing Reason 7 Choice")]
    public abstract partial record FailingReason7Choice_
    {
    }
}
