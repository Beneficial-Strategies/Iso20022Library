// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Status55Choice.
    /// </summary>
    [KnownType(typeof(RejectedStatus55Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus55Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus55Choice.NoSpecifiedReason),
        nameof(RejectedStatus55Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus55Choice.Reason), nameof(RejectedStatus55Choice.Reason))]
    [IsoId("_VUVUwX_WEe6NNIFrPQqloA")]
    [DisplayName("Rejected Status55Choice")]
    public abstract record RejectedStatus55Choice_ { }
}
