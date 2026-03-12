// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason22Choice.Code))]
    [KnownType(typeof(CancellationReason22Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason22Choice.Code),nameof(CancellationReason22Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason22Choice.Proprietary),nameof(CancellationReason22Choice.Proprietary))]
    [IsoId("_2k-biTt5EeW638lNyHKv7A")]
    [DisplayName("Cancellation Reason 22 Choice")]
    public abstract partial record CancellationReason22Choice_
    {
    }
}
