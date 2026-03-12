// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus13Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus13Choice.NoSpecifiedReason),nameof(RejectedStatus13Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus13Choice.Reason),nameof(RejectedStatus13Choice.Reason))]
    [IsoId("_inrW61hYEeSewsfsZR0hxA")]
    [DisplayName("Rejected Status 13 Choice")]
    public abstract partial record RejectedStatus13Choice_
    {
    }
}
