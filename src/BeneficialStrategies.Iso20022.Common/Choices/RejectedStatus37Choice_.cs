// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus37Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus37Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus37Choice.NoSpecifiedReason),nameof(RejectedStatus37Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus37Choice.Reason),nameof(RejectedStatus37Choice.Reason))]
    [IsoId("_F8_c0RHqEeuE0Pnt-OcNOA")]
    [DisplayName("Rejected Status 37 Choice")]
    public abstract partial record RejectedStatus37Choice_
    {
    }
}
