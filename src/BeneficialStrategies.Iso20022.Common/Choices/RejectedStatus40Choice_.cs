// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus40Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus40Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus40Choice.NoSpecifiedReason),
        nameof(RejectedStatus40Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus40Choice.Reason), nameof(RejectedStatus40Choice.Reason))]
    [IsoId("_9FBMjR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Rejected Status 40 Choice")]
    public abstract record RejectedStatus40Choice_ { }
}
