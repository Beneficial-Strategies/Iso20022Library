// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason10Choice.Code))]
    [KnownType(typeof(FailingReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason10Choice.Code),nameof(FailingReason10Choice.Code))]
    [JsonDerivedType(typeof(FailingReason10Choice.Proprietary),nameof(FailingReason10Choice.Proprietary))]
    [IsoId("_5SGO2ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Failing Reason 10 Choice")]
    public abstract partial record FailingReason10Choice_
    {
    }
}
