// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus47Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus47Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus47Choice.NoSpecifiedReason),nameof(RejectedStatus47Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus47Choice.Reason),nameof(RejectedStatus47Choice.Reason))]
    [IsoId("_peWZGTi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Status 47 Choice")]
    public abstract partial record RejectedStatus47Choice_
    {
    }
}
