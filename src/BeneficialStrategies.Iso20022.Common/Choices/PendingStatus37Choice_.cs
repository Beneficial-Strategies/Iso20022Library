// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus37Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus37Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus37Choice.NoSpecifiedReason),
        nameof(PendingStatus37Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus37Choice.Reason), nameof(PendingStatus37Choice.Reason))]
    [IsoId("_h0uKcTqOEeWyoP0PbocV1Q")]
    [DisplayName("Pending Status 37 Choice")]
    public abstract record PendingStatus37Choice_ { }
}
