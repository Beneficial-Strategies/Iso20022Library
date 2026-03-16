// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason32Choice.Code))]
    [KnownType(typeof(CancellationReason32Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason32Choice.Code),
        nameof(CancellationReason32Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason32Choice.Proprietary),
        nameof(CancellationReason32Choice.Proprietary)
    )]
    [IsoId("_EeVGUViCEea0N7AwCvR5KA")]
    [DisplayName("Cancellation Reason 32 Choice")]
    public abstract record CancellationReason32Choice_ { }
}
