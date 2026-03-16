// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus11Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus11Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus11Choice.NoSpecifiedReason),
        nameof(PendingStatus11Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus11Choice.Reason), nameof(PendingStatus11Choice.Reason))]
    [IsoId("_Qg1iEf41EeClUvPNHKL9Zw")]
    [DisplayName("Pending Status 11 Choice")]
    public abstract record PendingStatus11Choice_ { }
}
