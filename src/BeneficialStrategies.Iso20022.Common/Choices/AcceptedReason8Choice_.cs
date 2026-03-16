// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of an accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason8Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedReason8Choice.Reason))]
    [JsonDerivedType(
        typeof(AcceptedReason8Choice.NoSpecifiedReason),
        nameof(AcceptedReason8Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(AcceptedReason8Choice.Reason), nameof(AcceptedReason8Choice.Reason))]
    [IsoId("_UUFf8VjpEeOnqqBHs8Gasw")]
    [DisplayName("Accepted Reason 8 Choice")]
    public abstract record AcceptedReason8Choice_ { }
}
