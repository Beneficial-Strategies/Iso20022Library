// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus58Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus58Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus58Choice.NoSpecifiedReason),
        nameof(PendingStatus58Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus58Choice.Reason), nameof(PendingStatus58Choice.Reason))]
    [IsoId("_sjdwQeaEEemtTOaHuc_63w")]
    [DisplayName("Pending Status 58 Choice")]
    public abstract record PendingStatus58Choice_ { }
}
