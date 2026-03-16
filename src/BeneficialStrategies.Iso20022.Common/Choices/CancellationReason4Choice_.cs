// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason4Choice.Code))]
    [KnownType(typeof(CancellationReason4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason4Choice.Code),
        nameof(CancellationReason4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason4Choice.Proprietary),
        nameof(CancellationReason4Choice.Proprietary)
    )]
    [IsoId("_UXSHVtp-Ed-ak6NoX_4Aeg_67707561")]
    [DisplayName("Cancellation Reason 4 Choice")]
    public abstract record CancellationReason4Choice_ { }
}
