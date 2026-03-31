// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason11Choice.Code))]
    [KnownType(typeof(AcceptedReason11Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason11Choice.Code), nameof(AcceptedReason11Choice.Code))]
    [JsonDerivedType(
        typeof(AcceptedReason11Choice.Proprietary),
        nameof(AcceptedReason11Choice.Proprietary)
    )]
    [IsoId("_cgn4H5KQEeWHWpTQn1FFVg")]
    [DisplayName("Accepted Reason 11 Choice")]
    public abstract record AcceptedReason11Choice_ { }
}
