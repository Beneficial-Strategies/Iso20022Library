// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus9Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus9Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus9Choice.NoSpecifiedReason),
        nameof(PendingStatus9Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus9Choice.Reason), nameof(PendingStatus9Choice.Reason))]
    [IsoId("_Bsv4S_40EeClUvPNHKL9Zw")]
    [DisplayName("Pending Status 9 Choice")]
    public abstract record PendingStatus9Choice_ { }
}
