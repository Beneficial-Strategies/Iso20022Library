// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason25Choice.Code))]
    [KnownType(typeof(CancellationReason25Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason25Choice.Code),
        nameof(CancellationReason25Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason25Choice.Proprietary),
        nameof(CancellationReason25Choice.Proprietary)
    )]
    [IsoId("_6BHQsZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Reason 25 Choice")]
    public abstract record CancellationReason25Choice_ { }
}
