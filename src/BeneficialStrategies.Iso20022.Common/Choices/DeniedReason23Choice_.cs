// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason23Choice.Code))]
    [KnownType(typeof(DeniedReason23Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason23Choice.Code), nameof(DeniedReason23Choice.Code))]
    [JsonDerivedType(
        typeof(DeniedReason23Choice.Proprietary),
        nameof(DeniedReason23Choice.Proprietary)
    )]
    [IsoId("_8Qc2a5NLEeWGlc8L7oPDIg")]
    [DisplayName("Denied Reason 23 Choice")]
    public abstract record DeniedReason23Choice_ { }
}
