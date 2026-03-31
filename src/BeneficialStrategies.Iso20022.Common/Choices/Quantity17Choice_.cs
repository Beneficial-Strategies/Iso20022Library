// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity17Choice.QuantityChoice))]
    [KnownType(typeof(Quantity17Choice.ProprietaryQuantity))]
    [JsonDerivedType(
        typeof(Quantity17Choice.QuantityChoice),
        nameof(Quantity17Choice.QuantityChoice)
    )]
    [JsonDerivedType(
        typeof(Quantity17Choice.ProprietaryQuantity),
        nameof(Quantity17Choice.ProprietaryQuantity)
    )]
    [IsoId("_LllANzq5EeWQ1Y7f8kds2A")]
    [DisplayName("Quantity 17 Choice")]
    public abstract record Quantity17Choice_ { }
}
