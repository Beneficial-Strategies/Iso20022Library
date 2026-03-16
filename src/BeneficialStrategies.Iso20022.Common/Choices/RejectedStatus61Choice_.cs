// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Status61Choice.
    /// </summary>
    [KnownType(typeof(RejectedStatus61Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus61Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus61Choice.NoSpecifiedReason),nameof(RejectedStatus61Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus61Choice.Reason),nameof(RejectedStatus61Choice.Reason))]
    [IsoId("_taWcUZzoEe-DHYbvdRjdbA")]
    [DisplayName("Rejected Status61Choice")]
    public abstract partial record RejectedStatus61Choice_
    {
    }
}
