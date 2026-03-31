// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of an accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason7Choice.Code))]
    [KnownType(typeof(AcceptedReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedReason7Choice.Code), nameof(AcceptedReason7Choice.Code))]
    [JsonDerivedType(
        typeof(AcceptedReason7Choice.Proprietary),
        nameof(AcceptedReason7Choice.Proprietary)
    )]
    [IsoId("_PFE46ljzEeOnqqBHs8Gasw")]
    [DisplayName("Accepted Reason 7 Choice")]
    public abstract record AcceptedReason7Choice_ { }
}
