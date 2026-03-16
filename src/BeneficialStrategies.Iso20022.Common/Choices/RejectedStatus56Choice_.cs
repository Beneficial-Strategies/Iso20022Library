// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rejected Status56Choice.
    /// </summary>
    [KnownType(typeof(RejectedStatus56Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus56Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus56Choice.NoSpecifiedReason),nameof(RejectedStatus56Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus56Choice.Reason),nameof(RejectedStatus56Choice.Reason))]
    [IsoId("_ZAh5N1x1Ee6fgZt44_IqFA")]
    [DisplayName("Rejected Status56Choice")]
    public abstract partial record RejectedStatus56Choice_
    {
    }
}
