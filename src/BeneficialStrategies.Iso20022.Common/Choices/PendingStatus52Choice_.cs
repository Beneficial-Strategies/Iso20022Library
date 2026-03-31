// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus52Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus52Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus52Choice.NoSpecifiedReason),
        nameof(PendingStatus52Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus52Choice.Reason), nameof(PendingStatus52Choice.Reason))]
    [IsoId("_RvsMsYlsEeavwKddCbm3hg")]
    [DisplayName("Pending Status 52 Choice")]
    public abstract record PendingStatus52Choice_ { }
}
