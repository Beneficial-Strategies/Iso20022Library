// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Status70Choice.
    /// </summary>
    [KnownType(typeof(PendingStatus70Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus70Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus70Choice.NoSpecifiedReason),nameof(PendingStatus70Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus70Choice.Reason),nameof(PendingStatus70Choice.Reason))]
    [IsoId("_P2OQUVx2Ee6fgZt44_IqFA")]
    [DisplayName("Pending Status70Choice")]
    public abstract partial record PendingStatus70Choice_
    {
    }
}
