// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus9Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus9Choice.Reason))]
    [JsonDerivedType(
        typeof(AcceptedStatus9Choice.NoSpecifiedReason),
        nameof(AcceptedStatus9Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(AcceptedStatus9Choice.Reason), nameof(AcceptedStatus9Choice.Reason))]
    [IsoId("_cgn385KQEeWHWpTQn1FFVg")]
    [DisplayName("Accepted Status 9 Choice")]
    public abstract record AcceptedStatus9Choice_ { }
}
