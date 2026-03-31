// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason16Choice.Code))]
    [KnownType(typeof(DeniedReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason16Choice.Code), nameof(DeniedReason16Choice.Code))]
    [JsonDerivedType(
        typeof(DeniedReason16Choice.Proprietary),
        nameof(DeniedReason16Choice.Proprietary)
    )]
    [IsoId("_uWhgITs8EeWRTLSN0i0tng")]
    [DisplayName("Denied Reason 16 Choice")]
    public abstract record DeniedReason16Choice_ { }
}
