// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Status60Choice.
    /// </summary>
    [KnownType(typeof(RejectedStatus60Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus60Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus60Choice.NoSpecifiedReason),
        nameof(RejectedStatus60Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus60Choice.Reason), nameof(RejectedStatus60Choice.Reason))]
    [IsoId("_UqcwLXSdEe6VWZz2tTgENw")]
    [DisplayName("Rejected Status60Choice")]
    public abstract record RejectedStatus60Choice_ { }
}
