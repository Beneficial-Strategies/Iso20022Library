// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus39Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus39Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus39Choice.NoSpecifiedReason),
        nameof(RejectedStatus39Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus39Choice.Reason), nameof(RejectedStatus39Choice.Reason))]
    [IsoId("_pUIcGR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Rejected Status 39 Choice")]
    public abstract record RejectedStatus39Choice_ { }
}
