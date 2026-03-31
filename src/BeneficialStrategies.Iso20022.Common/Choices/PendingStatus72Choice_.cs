// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Status72Choice.
    /// </summary>
    [KnownType(typeof(PendingStatus72Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus72Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus72Choice.NoSpecifiedReason),
        nameof(PendingStatus72Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus72Choice.Reason), nameof(PendingStatus72Choice.Reason))]
    [IsoId("_UqcweXSdEe6VWZz2tTgENw")]
    [DisplayName("Pending Status72Choice")]
    public abstract record PendingStatus72Choice_ { }
}
