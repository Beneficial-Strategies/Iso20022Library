// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason and no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus27Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus27Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus27Choice.NoSpecifiedReason),nameof(RejectedStatus27Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus27Choice.Reason),nameof(RejectedStatus27Choice.Reason))]
    [IsoId("_bzV1YffREeiNZp_PtLohLw")]
    [DisplayName("Rejected Status 27 Choice")]
    public abstract partial record RejectedStatus27Choice_
    {
    }
}
