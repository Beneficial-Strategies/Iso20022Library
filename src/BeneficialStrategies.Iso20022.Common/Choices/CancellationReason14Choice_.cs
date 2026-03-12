// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [KnownType(typeof(CancellationReason14Choice.Code))]
    [KnownType(typeof(CancellationReason14Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationReason14Choice.Code),nameof(CancellationReason14Choice.Code))]
    [JsonDerivedType(typeof(CancellationReason14Choice.Proprietary),nameof(CancellationReason14Choice.Proprietary))]
    [IsoId("_t3j1IFkyEeGeoaLUQk__nA_1418440673")]
    [DisplayName("Cancellation Reason 14 Choice")]
    public abstract partial record CancellationReason14Choice_
    {
    }
}
