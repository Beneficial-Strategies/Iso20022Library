// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity23Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity23Choice.SignedQuantity))]
    [JsonDerivedType(
        typeof(Quantity23Choice.OriginalAndCurrentFaceAmount),
        nameof(Quantity23Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(
        typeof(Quantity23Choice.SignedQuantity),
        nameof(Quantity23Choice.SignedQuantity)
    )]
    [IsoId("_cfsEXZKQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity 23 Choice")]
    public abstract record Quantity23Choice_ { }
}
