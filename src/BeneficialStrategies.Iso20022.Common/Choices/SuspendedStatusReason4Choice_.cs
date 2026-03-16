// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for a suspended status.
    /// </summary>
    [KnownType(typeof(SuspendedStatusReason4Choice.NoSpecifiedReason))]
    [KnownType(typeof(SuspendedStatusReason4Choice.ReasonDetails))]
    [JsonDerivedType(
        typeof(SuspendedStatusReason4Choice.NoSpecifiedReason),
        nameof(SuspendedStatusReason4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(SuspendedStatusReason4Choice.ReasonDetails),
        nameof(SuspendedStatusReason4Choice.ReasonDetails)
    )]
    [IsoId("_Z5vRgUHlEea8I67lh6qdSQ")]
    [DisplayName("Suspended Status Reason 4 Choice")]
    public abstract record SuspendedStatusReason4Choice_ { }
}
