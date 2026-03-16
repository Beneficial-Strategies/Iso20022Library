// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus44Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus44Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus44Choice.NoSpecifiedReason),
        nameof(PendingStatus44Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus44Choice.Reason), nameof(PendingStatus44Choice.Reason))]
    [IsoId("_cgn4k5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Status 44 Choice")]
    public abstract record PendingStatus44Choice_ { }
}
