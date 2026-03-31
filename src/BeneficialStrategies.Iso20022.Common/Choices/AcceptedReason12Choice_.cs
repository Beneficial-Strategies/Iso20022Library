// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason12Choice.Code))]
    [KnownType(typeof(AcceptedReason12Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason12Choice.Code), nameof(AcceptedReason12Choice.Code))]
    [JsonDerivedType(
        typeof(AcceptedReason12Choice.Proprietary),
        nameof(AcceptedReason12Choice.Proprietary)
    )]
    [IsoId("_6HWbpZNLEeWGlc8L7oPDIg")]
    [DisplayName("Accepted Reason 12 Choice")]
    public abstract record AcceptedReason12Choice_ { }
}
