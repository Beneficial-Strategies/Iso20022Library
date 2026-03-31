// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus25Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus25Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus25Choice.NoSpecifiedReason),
        nameof(RejectedStatus25Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus25Choice.Reason), nameof(RejectedStatus25Choice.Reason))]
    [IsoId("_pZNIm7XTEeiTob_PrFFUxA")]
    [DisplayName("Rejected Status 25 Choice")]
    public abstract record RejectedStatus25Choice_ { }
}
