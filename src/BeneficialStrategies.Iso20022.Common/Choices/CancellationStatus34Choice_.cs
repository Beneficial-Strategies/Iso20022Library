// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus34Choice.GlobalCancellationStatus))]
    [KnownType(typeof(CancellationStatus34Choice.DetailedCancellationStatus))]
    [JsonDerivedType(typeof(CancellationStatus34Choice.GlobalCancellationStatus), nameof(CancellationStatus34Choice.GlobalCancellationStatus))]
    [JsonDerivedType(typeof(CancellationStatus34Choice.DetailedCancellationStatus), nameof(CancellationStatus34Choice.DetailedCancellationStatus))]
    [IsoId("_czhuwa8uEfCx2aBifPEdRg")]
    [DisplayName("CancellationStatus34Choice")]
    public abstract record CancellationStatus34Choice_ { }
}
