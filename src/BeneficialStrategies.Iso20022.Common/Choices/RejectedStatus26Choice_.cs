// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus26Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus26Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus26Choice.NoSpecifiedReason),
        nameof(RejectedStatus26Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus26Choice.Reason), nameof(RejectedStatus26Choice.Reason))]
    [IsoId("_Amu7Oby0EeilsanBGAzy4A")]
    [DisplayName("Rejected Status 26 Choice")]
    public abstract record RejectedStatus26Choice_ { }
}
