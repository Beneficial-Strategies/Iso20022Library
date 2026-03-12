// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the reason of a rejected status.
    /// </summary>
    [KnownType(typeof(RejectedReason8Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedReason8Choice.Reason))]
    [JsonDerivedType(typeof(RejectedReason8Choice.NoSpecifiedReason),nameof(RejectedReason8Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedReason8Choice.Reason),nameof(RejectedReason8Choice.Reason))]
    [IsoId("_tg-hCVj7EeOgwYxfAV02bg")]
    [DisplayName("Rejected Reason 8 Choice")]
    public abstract partial record RejectedReason8Choice_
    {
    }
}
