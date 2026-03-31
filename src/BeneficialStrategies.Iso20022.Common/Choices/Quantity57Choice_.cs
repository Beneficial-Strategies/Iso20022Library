// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity57Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity57Choice.SignedQuantity))]
    [JsonDerivedType(
        typeof(Quantity57Choice.OriginalAndCurrentFaceAmount),
        nameof(Quantity57Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(
        typeof(Quantity57Choice.SignedQuantity),
        nameof(Quantity57Choice.SignedQuantity)
    )]
    [IsoId("_pf0YwTi7Eeydid5dcNPKvg")]
    [DisplayName("Quantity 57 Choice")]
    public abstract record Quantity57Choice_ { }
}
