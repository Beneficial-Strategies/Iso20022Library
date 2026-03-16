// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus32Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus32Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus32Choice.NoSpecifiedReason),
        nameof(RejectedStatus32Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus32Choice.Reason), nameof(RejectedStatus32Choice.Reason))]
    [IsoId("_lrrtq-XyEemEj48jhmlA0Q")]
    [DisplayName("Rejected Status 32 Choice")]
    public abstract record RejectedStatus32Choice_ { }
}
