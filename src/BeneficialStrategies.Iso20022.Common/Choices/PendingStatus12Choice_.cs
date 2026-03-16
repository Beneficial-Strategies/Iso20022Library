// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus12Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus12Choice.NoSpecifiedReason),
        nameof(PendingStatus12Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus12Choice.Reason), nameof(PendingStatus12Choice.Reason))]
    [IsoId("_mz-NG_41EeClUvPNHKL9Zw")]
    [DisplayName("Pending Status 12 Choice")]
    public abstract record PendingStatus12Choice_ { }
}
