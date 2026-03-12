// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus39Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus39Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus39Choice.NoSpecifiedReason),nameof(PendingStatus39Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus39Choice.Reason),nameof(PendingStatus39Choice.Reason))]
    [IsoId("_jGBdoTq3EeWyoP0PbocV1Q")]
    [DisplayName("Pending Status 39 Choice")]
    public abstract partial record PendingStatus39Choice_
    {
    }
}
