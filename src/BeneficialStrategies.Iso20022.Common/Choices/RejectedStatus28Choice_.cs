// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus28Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus28Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus28Choice.NoSpecifiedReason),nameof(RejectedStatus28Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus28Choice.Reason),nameof(RejectedStatus28Choice.Reason))]
    [IsoId("_EPeB8f0qEeiKOe8GCUL1Lg")]
    [DisplayName("Rejected Status 28 Choice")]
    public abstract partial record RejectedStatus28Choice_
    {
    }
}
