// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Status59Choice.
    /// </summary>
    [KnownType(typeof(RejectedStatus59Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus59Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus59Choice.NoSpecifiedReason),
        nameof(RejectedStatus59Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus59Choice.Reason), nameof(RejectedStatus59Choice.Reason))]
    [IsoId("_Uo2NuXSdEe6VWZz2tTgENw")]
    [DisplayName("Rejected Status59Choice")]
    public abstract record RejectedStatus59Choice_ { }
}
