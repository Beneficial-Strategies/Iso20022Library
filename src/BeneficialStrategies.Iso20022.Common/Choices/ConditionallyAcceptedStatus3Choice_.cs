// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for a conditionally accepted status.
    /// </summary>
    [KnownType(typeof(ConditionallyAcceptedStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(ConditionallyAcceptedStatus3Choice.ReasonDetails))]
    [JsonDerivedType(
        typeof(ConditionallyAcceptedStatus3Choice.NoSpecifiedReason),
        nameof(ConditionallyAcceptedStatus3Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ConditionallyAcceptedStatus3Choice.ReasonDetails),
        nameof(ConditionallyAcceptedStatus3Choice.ReasonDetails)
    )]
    [IsoId("_scSIAUHXEeamVPoS58KxXA")]
    [DisplayName("Conditionally Accepted Status 3 Choice")]
    public abstract record ConditionallyAcceptedStatus3Choice_ { }
}
