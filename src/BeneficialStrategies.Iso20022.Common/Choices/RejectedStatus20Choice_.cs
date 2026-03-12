// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus20Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus20Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus20Choice.NoSpecifiedReason),nameof(RejectedStatus20Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus20Choice.Reason),nameof(RejectedStatus20Choice.Reason))]
    [IsoId("_ce_gRZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rejected Status 20 Choice")]
    public abstract partial record RejectedStatus20Choice_
    {
    }
}
