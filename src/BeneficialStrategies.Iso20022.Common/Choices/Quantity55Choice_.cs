// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats of securities quantity.
    /// </summary>
    [KnownType(typeof(Quantity55Choice.Code))]
    [KnownType(typeof(Quantity55Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity55Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity55Choice.Code),nameof(Quantity55Choice.Code))]
    [JsonDerivedType(typeof(Quantity55Choice.OriginalAndCurrentFaceAmount),nameof(Quantity55Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity55Choice.Quantity),nameof(Quantity55Choice.Quantity))]
    [IsoId("_pfIcYzi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 55 Choice")]
    public abstract partial record Quantity55Choice_
    {
    }
}
