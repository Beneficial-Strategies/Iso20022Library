// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus57Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus57Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus57Choice.NoSpecifiedReason),
        nameof(PendingStatus57Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus57Choice.Reason), nameof(PendingStatus57Choice.Reason))]
    [IsoId("_jx4dweXzEemEj48jhmlA0Q")]
    [DisplayName("Pending Status 57 Choice")]
    public abstract record PendingStatus57Choice_ { }
}
