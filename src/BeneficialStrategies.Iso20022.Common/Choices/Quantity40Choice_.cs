// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity40Choice.Code))]
    [KnownType(typeof(Quantity40Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity40Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity40Choice.Code), nameof(Quantity40Choice.Code))]
    [JsonDerivedType(
        typeof(Quantity40Choice.OriginalAndCurrentFaceAmount),
        nameof(Quantity40Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(typeof(Quantity40Choice.Quantity), nameof(Quantity40Choice.Quantity))]
    [IsoId("_NwxZGJp3EeWLs7cvLxlyAg")]
    [DisplayName("Quantity 40 Choice")]
    public abstract record Quantity40Choice_ { }
}
