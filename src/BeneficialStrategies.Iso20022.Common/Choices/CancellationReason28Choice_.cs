// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason28Choice.Code))]
    [KnownType(typeof(CancellationReason28Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason28Choice.Code),
        nameof(CancellationReason28Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason28Choice.Proprietary),
        nameof(CancellationReason28Choice.Proprietary)
    )]
    [IsoId("_6QFgqZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Reason 28 Choice")]
    public abstract record CancellationReason28Choice_ { }
}
