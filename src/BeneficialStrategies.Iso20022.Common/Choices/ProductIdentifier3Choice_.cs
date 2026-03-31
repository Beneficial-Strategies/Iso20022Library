// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Product Identifier3Choice.
    /// </summary>
    [KnownType(typeof(ProductIdentifier3Choice.UnderlyingProductIdentifier))]
    [KnownType(typeof(ProductIdentifier3Choice.UniqueProductIdentifier))]
    [JsonDerivedType(
        typeof(ProductIdentifier3Choice.UnderlyingProductIdentifier),
        nameof(ProductIdentifier3Choice.UnderlyingProductIdentifier)
    )]
    [JsonDerivedType(
        typeof(ProductIdentifier3Choice.UniqueProductIdentifier),
        nameof(ProductIdentifier3Choice.UniqueProductIdentifier)
    )]
    [IsoId("_V3jkcEj2Ee-KhcStGV4xTg")]
    [DisplayName("Product Identifier3Choice")]
    public abstract record ProductIdentifier3Choice_ { }
}
