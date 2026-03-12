// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason19Choice.Code))]
    [KnownType(typeof(CancellationReason19Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason19Choice.Code),nameof(CancellationReason19Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason19Choice.Proprietary),nameof(CancellationReason19Choice.Proprietary))]
    [IsoId("_ilpt4TnuEeWfSKvvZlhRKg")]
    [DisplayName("Cancellation Reason 19 Choice")]
    public abstract partial record CancellationReason19Choice_
    {
    }
}
