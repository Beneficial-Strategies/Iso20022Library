// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason17Choice.Code))]
    [KnownType(typeof(DeniedReason17Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason17Choice.Code), nameof(DeniedReason17Choice.Code))]
    [JsonDerivedType(
        typeof(DeniedReason17Choice.Proprietary),
        nameof(DeniedReason17Choice.Proprietary)
    )]
    [IsoId("_AKouMTw-EeW3QqUkIQtIUA")]
    [DisplayName("Denied Reason 17 Choice")]
    public abstract record DeniedReason17Choice_ { }
}
