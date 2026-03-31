// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus23Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus23Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus23Choice.NoSpecifiedReason),
        nameof(RejectedStatus23Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus23Choice.Reason), nameof(RejectedStatus23Choice.Reason))]
    [IsoId("_GxRCa4lqEeavwKddCbm3hg")]
    [DisplayName("Rejected Status 23 Choice")]
    public abstract record RejectedStatus23Choice_ { }
}
