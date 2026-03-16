// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity21Choice.Quantity))]
    [KnownType(typeof(Quantity21Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity21Choice.Quantity), nameof(Quantity21Choice.Quantity))]
    [JsonDerivedType(
        typeof(Quantity21Choice.ProprietaryQuantity),
        nameof(Quantity21Choice.ProprietaryQuantity)
    )]
    [IsoId("_cfAuo5KQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity 21 Choice")]
    public abstract record Quantity21Choice_ { }
}
