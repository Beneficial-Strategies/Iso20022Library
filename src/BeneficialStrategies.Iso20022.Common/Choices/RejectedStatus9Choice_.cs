// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus9Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus9Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus9Choice.NoSpecifiedReason),nameof(RejectedStatus9Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus9Choice.Reason),nameof(RejectedStatus9Choice.Reason))]
    [IsoId("_POQgwSd0EeOXAt_43VmZGw")]
    [DisplayName("Rejected Status 9 Choice")]
    public abstract partial record RejectedStatus9Choice_
    {
    }
}
