// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity18Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity18Choice.SignedQuantity))]
    [JsonDerivedType(typeof(Quantity18Choice.OriginalAndCurrentFaceAmount),nameof(Quantity18Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity18Choice.SignedQuantity),nameof(Quantity18Choice.SignedQuantity))]
    [IsoId("_LyFLJzq5EeWQ1Y7f8kds2A")]
    [DisplayName("Quantity 18 Choice")]
    public abstract partial record Quantity18Choice_
    {
    }
}
