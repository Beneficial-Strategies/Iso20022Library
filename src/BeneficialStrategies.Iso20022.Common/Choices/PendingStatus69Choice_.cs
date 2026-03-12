// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus69Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus69Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus69Choice.NoSpecifiedReason),nameof(PendingStatus69Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus69Choice.Reason),nameof(PendingStatus69Choice.Reason))]
    [IsoId("_f99MEzi8Eeydid5dcNPKvg")]
    [DisplayName("Pending Status 69 Choice")]
    public abstract partial record PendingStatus69Choice_
    {
    }
}
