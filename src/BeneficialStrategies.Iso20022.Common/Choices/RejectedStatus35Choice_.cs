// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus35Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus35Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus35Choice.NoSpecifiedReason),nameof(RejectedStatus35Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus35Choice.Reason),nameof(RejectedStatus35Choice.Reason))]
    [IsoId("_4YiuG-6KEeqc-LCjwLsUVg")]
    [DisplayName("Rejected Status 35 Choice")]
    public abstract partial record RejectedStatus35Choice_
    {
    }
}
