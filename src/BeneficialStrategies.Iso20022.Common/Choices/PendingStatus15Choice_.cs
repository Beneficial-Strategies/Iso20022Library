// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus15Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus15Choice.NoSpecifiedReason),
        nameof(PendingStatus15Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus15Choice.Reason), nameof(PendingStatus15Choice.Reason))]
    [IsoId("_bfizy_7rEeCvPoRGOxRobQ")]
    [DisplayName("Pending Status 15 Choice")]
    public abstract record PendingStatus15Choice_ { }
}
