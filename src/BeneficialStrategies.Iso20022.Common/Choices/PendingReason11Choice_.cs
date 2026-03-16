// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason11Choice.Code))]
    [KnownType(typeof(PendingReason11Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason11Choice.Code), nameof(PendingReason11Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason11Choice.Proprietary),
        nameof(PendingReason11Choice.Proprietary)
    )]
    [IsoId("_itAofUAAEeCaq78Ig8ATcA")]
    [DisplayName("Pending Reason 11 Choice")]
    public abstract record PendingReason11Choice_ { }
}
