// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus45Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus45Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus45Choice.NoSpecifiedReason),nameof(RejectedStatus45Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus45Choice.Reason),nameof(RejectedStatus45Choice.Reason))]
    [IsoId("_pf-JVTi7Eeydid5dcNPKvg")]
    [DisplayName("Rejected Status 45 Choice")]
    public abstract partial record RejectedStatus45Choice_
    {
    }
}
