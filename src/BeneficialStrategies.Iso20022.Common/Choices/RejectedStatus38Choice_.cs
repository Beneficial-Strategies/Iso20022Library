// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus38Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus38Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus38Choice.NoSpecifiedReason),
        nameof(RejectedStatus38Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus38Choice.Reason), nameof(RejectedStatus38Choice.Reason))]
    [IsoId("_JilvoRUNEeuYppTwWp55gA")]
    [DisplayName("Rejected Status 38 Choice")]
    public abstract record RejectedStatus38Choice_ { }
}
