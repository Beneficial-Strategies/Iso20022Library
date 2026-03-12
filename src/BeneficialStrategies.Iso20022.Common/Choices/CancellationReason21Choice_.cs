// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason21Choice.Code))]
    [KnownType(typeof(CancellationReason21Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason21Choice.Code),nameof(CancellationReason21Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason21Choice.Proprietary),nameof(CancellationReason21Choice.Proprietary))]
    [IsoId("_MxX5ATs9EeWRTLSN0i0tng")]
    [DisplayName("Cancellation Reason 21 Choice")]
    public abstract partial record CancellationReason21Choice_
    {
    }
}
