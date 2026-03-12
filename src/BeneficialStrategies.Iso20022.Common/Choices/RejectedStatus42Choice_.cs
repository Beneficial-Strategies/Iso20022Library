// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus42Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus42Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus42Choice.NoSpecifiedReason),nameof(RejectedStatus42Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus42Choice.Reason),nameof(RejectedStatus42Choice.Reason))]
    [IsoId("_V5aGqxn0EeyroI8qKgB7Mg")]
    [DisplayName("Rejected Status 42 Choice")]
    public abstract partial record RejectedStatus42Choice_
    {
    }
}
