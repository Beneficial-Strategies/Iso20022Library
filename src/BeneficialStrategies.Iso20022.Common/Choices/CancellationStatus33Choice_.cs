// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status is cancelled.
    /// </summary>
    [KnownType(typeof(CancellationStatus33Choice.Status))]
    [KnownType(typeof(CancellationStatus33Choice.Rejected))]
    [JsonDerivedType(typeof(CancellationStatus33Choice.Status), nameof(CancellationStatus33Choice.Status))]
    [JsonDerivedType(typeof(CancellationStatus33Choice.Rejected), nameof(CancellationStatus33Choice.Rejected))]
    [IsoId("4c142481-2d10-478e-a071-2601f7c8dfa2")]
    [DisplayName("CancellationStatus33Choice")]
    public abstract record CancellationStatus33Choice_ { }
}
