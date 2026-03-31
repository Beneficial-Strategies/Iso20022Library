// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectedStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus10Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus10Choice.NoSpecifiedReason),
        nameof(RejectedStatus10Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus10Choice.Reason), nameof(RejectedStatus10Choice.Reason))]
    [IsoId("_LuBzcCzTEeOsiuMH68so7Q")]
    [DisplayName("Rejected Status 10 Choice")]
    public abstract record RejectedStatus10Choice_ { }
}
