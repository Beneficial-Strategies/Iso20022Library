// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus34Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus34Choice.NoSpecifiedReason),nameof(PendingStatus34Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus34Choice.Reason),nameof(PendingStatus34Choice.Reason))]
    [IsoId("_T9xmsVhbEeSewsfsZR0hxA")]
    [DisplayName("Pending Status 34 Choice")]
    public abstract partial record PendingStatus34Choice_
    {
    }
}
