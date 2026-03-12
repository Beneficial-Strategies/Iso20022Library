// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [KnownType(typeof(CancellationReason16Choice.Code))]
    [KnownType(typeof(CancellationReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason16Choice.Code),nameof(CancellationReason16Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason16Choice.Proprietary),nameof(CancellationReason16Choice.Proprietary))]
    [IsoId("_jG0jFu5NEeCisYr99QEiWA_-267474018")]
    [DisplayName("Cancellation Reason 16 Choice")]
    public abstract partial record CancellationReason16Choice_
    {
    }
}
