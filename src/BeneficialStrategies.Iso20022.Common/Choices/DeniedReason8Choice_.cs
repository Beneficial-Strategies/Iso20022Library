// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason8Choice.Code))]
    [KnownType(typeof(DeniedReason8Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason8Choice.Code), nameof(DeniedReason8Choice.Code))]
    [JsonDerivedType(
        typeof(DeniedReason8Choice.Proprietary),
        nameof(DeniedReason8Choice.Proprietary)
    )]
    [IsoId("_Iul8wVjwEeSYweXGddZAOA")]
    [DisplayName("Denied Reason 8 Choice")]
    public abstract record DeniedReason8Choice_ { }
}
