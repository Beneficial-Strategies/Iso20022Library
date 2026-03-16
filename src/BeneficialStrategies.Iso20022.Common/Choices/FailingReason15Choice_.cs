// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason15Choice.Code))]
    [KnownType(typeof(FailingReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason15Choice.Code), nameof(FailingReason15Choice.Code))]
    [JsonDerivedType(
        typeof(FailingReason15Choice.Proprietary),
        nameof(FailingReason15Choice.Proprietary)
    )]
    [IsoId("_8Qdc15NLEeWGlc8L7oPDIg")]
    [DisplayName("Failing Reason 15 Choice")]
    public abstract record FailingReason15Choice_ { }
}
