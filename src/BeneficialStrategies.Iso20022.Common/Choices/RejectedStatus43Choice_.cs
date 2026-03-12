// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus43Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus43Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus43Choice.NoSpecifiedReason),nameof(RejectedStatus43Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus43Choice.Reason),nameof(RejectedStatus43Choice.Reason))]
    [IsoId("_KVKx-xn1EeyroI8qKgB7Mg")]
    [DisplayName("Rejected Status 43 Choice")]
    public abstract partial record RejectedStatus43Choice_
    {
    }
}
