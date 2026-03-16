// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectedStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus17Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus17Choice.NoSpecifiedReason),
        nameof(RejectedStatus17Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus17Choice.Reason), nameof(RejectedStatus17Choice.Reason))]
    [IsoId("_db1M1zt5EeW638lNyHKv7A")]
    [DisplayName("Rejected Status 17 Choice")]
    public abstract record RejectedStatus17Choice_ { }
}
