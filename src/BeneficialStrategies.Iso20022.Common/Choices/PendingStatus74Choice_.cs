// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Status74Choice.
    /// </summary>
    [KnownType(typeof(PendingStatus74Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus74Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus74Choice.NoSpecifiedReason),
        nameof(PendingStatus74Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus74Choice.Reason), nameof(PendingStatus74Choice.Reason))]
    [IsoId("_salnMZB0Ee-COKgew96POA")]
    [DisplayName("Pending Status74Choice")]
    public abstract record PendingStatus74Choice_ { }
}
