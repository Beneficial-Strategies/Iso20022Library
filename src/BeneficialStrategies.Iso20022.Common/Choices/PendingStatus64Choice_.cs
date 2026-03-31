// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus64Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus64Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus64Choice.NoSpecifiedReason),
        nameof(PendingStatus64Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus64Choice.Reason), nameof(PendingStatus64Choice.Reason))]
    [IsoId("_qTHeNyAdEeuyDZ-ukt4YRg")]
    [DisplayName("Pending Status 64 Choice")]
    public abstract record PendingStatus64Choice_ { }
}
