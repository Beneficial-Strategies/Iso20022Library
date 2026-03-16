// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus3Choice.Reason))]
    [JsonDerivedType(
        typeof(AcceptedStatus3Choice.NoSpecifiedReason),
        nameof(AcceptedStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(AcceptedStatus3Choice.Reason), nameof(AcceptedStatus3Choice.Reason))]
    [IsoId("_OM_NkSqAEeO3oOoGGWHH4A")]
    [DisplayName("Accepted Status 3 Choice")]
    public abstract record AcceptedStatus3Choice_ { }
}
