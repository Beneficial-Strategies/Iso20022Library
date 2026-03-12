// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is polypropylene.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPolypropylene3Choice.Plastic))]
    [KnownType(typeof(AssetClassCommodityPolypropylene3Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityPolypropylene3Choice.Plastic),nameof(AssetClassCommodityPolypropylene3Choice.Plastic))]
    [JsonDerivedType(typeof(AssetClassCommodityPolypropylene3Choice.Other),nameof(AssetClassCommodityPolypropylene3Choice.Other))]
    [IsoId("_IX9wAbv9EeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Polypropylene 3 Choice")]
    public abstract partial record AssetClassCommodityPolypropylene3Choice_
    {
    }
}
