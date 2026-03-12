// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus41Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus41Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus41Choice.NoSpecifiedReason),nameof(RejectedStatus41Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus41Choice.Reason),nameof(RejectedStatus41Choice.Reason))]
    [IsoId("_dxaPqxnyEeyroI8qKgB7Mg")]
    [DisplayName("Rejected Status 41 Choice")]
    public abstract partial record RejectedStatus41Choice_
    {
    }
}
