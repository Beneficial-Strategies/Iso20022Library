// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason3Choice.Code))]
    [KnownType(typeof(AcceptedReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason3Choice.Code),nameof(AcceptedReason3Choice.Code))]
    [JsonDerivedType(typeof(AcceptedReason3Choice.Proprietary),nameof(AcceptedReason3Choice.Proprietary))]
    [IsoId("_O72ewyqAEeO3oOoGGWHH4A")]
    [DisplayName("Accepted Reason 3 Choice")]
    public abstract partial record AcceptedReason3Choice_
    {
    }
}
