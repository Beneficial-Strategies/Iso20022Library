// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus4Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus4Choice.NoSpecifiedReason),
        nameof(PendingStatus4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus4Choice.Reason), nameof(PendingStatus4Choice.Reason))]
    [IsoId("_UYoLItp-Ed-ak6NoX_4Aeg_689331425")]
    [DisplayName("Pending Status 4 Choice")]
    public abstract record PendingStatus4Choice_ { }
}
