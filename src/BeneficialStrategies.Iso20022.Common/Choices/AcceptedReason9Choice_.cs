// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason9Choice.Code))]
    [KnownType(typeof(AcceptedReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason9Choice.Code), nameof(AcceptedReason9Choice.Code))]
    [JsonDerivedType(
        typeof(AcceptedReason9Choice.Proprietary),
        nameof(AcceptedReason9Choice.Proprietary)
    )]
    [IsoId("_LN8Dmzt6EeW638lNyHKv7A")]
    [DisplayName("Accepted Reason 9 Choice")]
    public abstract record AcceptedReason9Choice_ { }
}
