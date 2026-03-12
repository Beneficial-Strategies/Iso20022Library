// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus46Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus46Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus46Choice.NoSpecifiedReason),nameof(RejectedStatus46Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus46Choice.Reason),nameof(RejectedStatus46Choice.Reason))]
    [IsoId("_piJTwzi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Status 46 Choice")]
    public abstract partial record RejectedStatus46Choice_
    {
    }
}
