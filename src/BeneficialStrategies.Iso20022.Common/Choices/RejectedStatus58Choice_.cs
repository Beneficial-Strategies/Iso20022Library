// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Status58Choice.
    /// </summary>
    [KnownType(typeof(RejectedStatus58Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus58Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus58Choice.NoSpecifiedReason),
        nameof(RejectedStatus58Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus58Choice.Reason), nameof(RejectedStatus58Choice.Reason))]
    [IsoId("_xOoG8W5zEe6a272CIEgzKw")]
    [DisplayName("Rejected Status58Choice")]
    public abstract record RejectedStatus58Choice_ { }
}
