// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity19Choice.Quantity))]
    [KnownType(typeof(Quantity19Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity19Choice.Quantity), nameof(Quantity19Choice.Quantity))]
    [JsonDerivedType(
        typeof(Quantity19Choice.ProprietaryQuantity),
        nameof(Quantity19Choice.ProprietaryQuantity)
    )]
    [IsoId("_XFWZsTq6EeWQ1Y7f8kds2A")]
    [DisplayName("Quantity 19 Choice")]
    public abstract record Quantity19Choice_ { }
}
