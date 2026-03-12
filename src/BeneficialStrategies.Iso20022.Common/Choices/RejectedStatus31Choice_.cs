// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus31Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus31Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus31Choice.NoSpecifiedReason),nameof(RejectedStatus31Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus31Choice.Reason),nameof(RejectedStatus31Choice.Reason))]
    [IsoId("_g_hzSbKgEemux5trsZcCpw")]
    [DisplayName("Rejected Status 31 Choice")]
    public abstract partial record RejectedStatus31Choice_
    {
    }
}
