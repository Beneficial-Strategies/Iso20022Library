// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Status75Choice.
    /// </summary>
    [KnownType(typeof(PendingStatus75Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus75Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus75Choice.NoSpecifiedReason),
        nameof(PendingStatus75Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus75Choice.Reason), nameof(PendingStatus75Choice.Reason))]
    [IsoId("_jWq6A5t3Ee-wQIOX0djF2w")]
    [DisplayName("Pending Status75Choice")]
    public abstract record PendingStatus75Choice_ { }
}
