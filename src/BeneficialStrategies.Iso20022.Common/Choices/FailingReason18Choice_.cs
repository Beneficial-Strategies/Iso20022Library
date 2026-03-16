// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Failing Reason18Choice.
    /// </summary>
    [KnownType(typeof(FailingReason18Choice.Code))]
    [KnownType(typeof(FailingReason18Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason18Choice.Code), nameof(FailingReason18Choice.Code))]
    [JsonDerivedType(
        typeof(FailingReason18Choice.Proprietary),
        nameof(FailingReason18Choice.Proprietary)
    )]
    [IsoId("_84ez8YcTEe-FecylWsA1vA")]
    [DisplayName("Failing Reason18Choice")]
    public abstract record FailingReason18Choice_ { }
}
