// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus38Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus38Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus38Choice.NoSpecifiedReason),nameof(PendingStatus38Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus38Choice.Reason),nameof(PendingStatus38Choice.Reason))]
    [IsoId("_FnU34TqfEeWyoP0PbocV1Q")]
    [DisplayName("Pending Status 38 Choice")]
    public abstract partial record PendingStatus38Choice_
    {
    }
}
