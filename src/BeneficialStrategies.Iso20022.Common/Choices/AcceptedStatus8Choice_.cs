// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(AcceptedStatus8Choice.Reason))]
    [JsonDerivedType(
        typeof(AcceptedStatus8Choice.NoSpecifiedReason),
        nameof(AcceptedStatus8Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(AcceptedStatus8Choice.Reason), nameof(AcceptedStatus8Choice.Reason))]
    [IsoId("_4ZLV0UGUEeWqy4niLuXETA")]
    [DisplayName("Accepted Status 8 Choice")]
    public abstract record AcceptedStatus8Choice_ { }
}
