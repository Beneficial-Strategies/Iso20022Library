// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason26Choice.Code))]
    [KnownType(typeof(PendingReason26Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason26Choice.Code), nameof(PendingReason26Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason26Choice.Proprietary),
        nameof(PendingReason26Choice.Proprietary)
    )]
    [IsoId("_lJ0DkTp5EeWVrPy0StzzSg")]
    [DisplayName("Pending Reason 26 Choice")]
    public abstract record PendingReason26Choice_ { }
}
