// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request is cancelled.
    /// </summary>
    [KnownType(typeof(CancelledReason10Choice.Code))]
    [KnownType(typeof(CancelledReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(CancelledReason10Choice.Code),nameof(CancelledReason10Choice.Code))]
    [JsonDerivedType(typeof(CancelledReason10Choice.Proprietary),nameof(CancelledReason10Choice.Proprietary))]
    [IsoId("_ce-6A5KQEeWHWpTQn1FFVg")]
    [DisplayName("Cancelled Reason 10 Choice")]
    public abstract partial record CancelledReason10Choice_
    {
    }
}
