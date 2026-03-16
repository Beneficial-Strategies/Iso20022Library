// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancellationStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationStatus4Choice.Reason))]
    [JsonDerivedType(
        typeof(CancellationStatus4Choice.NoSpecifiedReason),
        nameof(CancellationStatus4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus4Choice.Reason),
        nameof(CancellationStatus4Choice.Reason)
    )]
    [IsoId("_UZEQA9p-Ed-ak6NoX_4Aeg_-974553783")]
    [DisplayName("Cancellation Status 4 Choice")]
    public abstract record CancellationStatus4Choice_ { }
}
