// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason24Choice.Code))]
    [KnownType(typeof(CancellationReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason24Choice.Code),nameof(CancellationReason24Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason24Choice.Proprietary),nameof(CancellationReason24Choice.Proprietary))]
    [IsoId("_5SFnXZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Reason 24 Choice")]
    public abstract partial record CancellationReason24Choice_
    {
    }
}
