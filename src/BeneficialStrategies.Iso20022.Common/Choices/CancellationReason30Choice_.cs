// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason30Choice.Code))]
    [KnownType(typeof(CancellationReason30Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason30Choice.Code),
        nameof(CancellationReason30Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason30Choice.Proprietary),
        nameof(CancellationReason30Choice.Proprietary)
    )]
    [IsoId("_8Qc2E5NLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Reason 30 Choice")]
    public abstract record CancellationReason30Choice_ { }
}
