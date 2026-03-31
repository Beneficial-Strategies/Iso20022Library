// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason11Choice.Code))]
    [KnownType(typeof(CancelledReason11Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason11Choice.Code), nameof(CancelledReason11Choice.Code))]
    [JsonDerivedType(
        typeof(CancelledReason11Choice.Proprietary),
        nameof(CancelledReason11Choice.Proprietary)
    )]
    [IsoId("_cgnRw5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cancelled Reason 11 Choice")]
    public abstract record CancelledReason11Choice_ { }
}
