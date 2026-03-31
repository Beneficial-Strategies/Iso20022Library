// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason18Choice.Code))]
    [KnownType(typeof(DeniedReason18Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason18Choice.Code), nameof(DeniedReason18Choice.Code))]
    [JsonDerivedType(
        typeof(DeniedReason18Choice.Proprietary),
        nameof(DeniedReason18Choice.Proprietary)
    )]
    [IsoId("_6BLiL5NLEeWGlc8L7oPDIg")]
    [DisplayName("Denied Reason 18 Choice")]
    public abstract record DeniedReason18Choice_ { }
}
