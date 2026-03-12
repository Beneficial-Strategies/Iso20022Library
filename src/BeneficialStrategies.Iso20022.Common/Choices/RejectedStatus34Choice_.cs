// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus34Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus34Choice.NoSpecifiedReason),nameof(RejectedStatus34Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus34Choice.Reason),nameof(RejectedStatus34Choice.Reason))]
    [IsoId("_bHlEm-6BEeqc-LCjwLsUVg")]
    [DisplayName("Rejected Status 34 Choice")]
    public abstract partial record RejectedStatus34Choice_
    {
    }
}
