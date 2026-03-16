// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus54Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus54Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus54Choice.NoSpecifiedReason),
        nameof(RejectedStatus54Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus54Choice.Reason), nameof(RejectedStatus54Choice.Reason))]
    [IsoId("_NpuWOF99Ee262vCSVgjImg")]
    [DisplayName("Rejected Status 54 Choice")]
    public abstract record RejectedStatus54Choice_ { }
}
