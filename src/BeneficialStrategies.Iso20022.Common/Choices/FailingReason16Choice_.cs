// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the failing reason.
    /// </summary>
    [KnownType(typeof(FailingReason16Choice.Code))]
    [KnownType(typeof(FailingReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(FailingReason16Choice.Code), nameof(FailingReason16Choice.Code))]
    [JsonDerivedType(
        typeof(FailingReason16Choice.Proprietary),
        nameof(FailingReason16Choice.Proprietary)
    )]
    [IsoId("_-e4jASW-EeygjNFjAlVoPA")]
    [DisplayName("Failing Reason 16 Choice")]
    public abstract record FailingReason16Choice_ { }
}
