// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the general meeting instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus55Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus55Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus55Choice.NoSpecifiedReason),
        nameof(PendingStatus55Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus55Choice.Reason), nameof(PendingStatus55Choice.Reason))]
    [IsoId("_Tfp1KbKdEemux5trsZcCpw")]
    [DisplayName("Pending Status 55 Choice")]
    public abstract record PendingStatus55Choice_ { }
}
