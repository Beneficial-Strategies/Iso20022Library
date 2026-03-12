// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason5Choice.Code))]
    [KnownType(typeof(CancellationReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason5Choice.Code),nameof(CancellationReason5Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason5Choice.Proprietary),nameof(CancellationReason5Choice.Proprietary))]
    [IsoId("_UY7GFtp-Ed-ak6NoX_4Aeg_1435301661")]
    [DisplayName("Cancellation Reason 5 Choice")]
    public abstract partial record CancellationReason5Choice_
    {
    }
}
