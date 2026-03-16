// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [KnownType(typeof(CancellationReason33Choice.Code))]
    [KnownType(typeof(CancellationReason33Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason33Choice.Code),
        nameof(CancellationReason33Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason33Choice.Proprietary),
        nameof(CancellationReason33Choice.Proprietary)
    )]
    [IsoId("_wjlEiUgtEeaGKYpLDboHPQ")]
    [DisplayName("Cancellation Reason 33 Choice")]
    public abstract record CancellationReason33Choice_ { }
}
