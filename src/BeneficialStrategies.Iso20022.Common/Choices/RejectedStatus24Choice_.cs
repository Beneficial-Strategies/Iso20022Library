// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus24Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus24Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus24Choice.NoSpecifiedReason),
        nameof(RejectedStatus24Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus24Choice.Reason), nameof(RejectedStatus24Choice.Reason))]
    [IsoId("_kov6Q5wsEeazcsnODTksnQ")]
    [DisplayName("Rejected Status 24 Choice")]
    public abstract record RejectedStatus24Choice_ { }
}
