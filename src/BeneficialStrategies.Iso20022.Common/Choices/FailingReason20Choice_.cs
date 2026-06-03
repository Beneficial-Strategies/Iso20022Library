// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason20Choice.Code))]
    [KnownType(typeof(FailingReason20Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason20Choice.Code), nameof(FailingReason20Choice.Code))]
    [JsonDerivedType(typeof(FailingReason20Choice.Proprietary), nameof(FailingReason20Choice.Proprietary))]
    [IsoId("_0w8A0eSkEe-qVZLXW4RRBw")]
    [DisplayName("Failing Reason 20 Choice")]
    public abstract record FailingReason20Choice_ { }
}
