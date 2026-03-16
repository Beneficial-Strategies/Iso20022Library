// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the general meeting instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus30Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus30Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus30Choice.NoSpecifiedReason),
        nameof(RejectedStatus30Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus30Choice.Reason), nameof(RejectedStatus30Choice.Reason))]
    [IsoId("_AGV-ebKaEemux5trsZcCpw")]
    [DisplayName("Rejected Status 30 Choice")]
    public abstract record RejectedStatus30Choice_ { }
}
