// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is industrial product.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityIndustrialProduct1Choice.Construction))]
    [KnownType(typeof(AssetClassCommodityIndustrialProduct1Choice.Manufacturing))]
    [JsonDerivedType(
        typeof(AssetClassCommodityIndustrialProduct1Choice.Construction),
        nameof(AssetClassCommodityIndustrialProduct1Choice.Construction)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityIndustrialProduct1Choice.Manufacturing),
        nameof(AssetClassCommodityIndustrialProduct1Choice.Manufacturing)
    )]
    [IsoId("_5jkmIFrfEeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Industrial Product 1 Choice")]
    public abstract record AssetClassCommodityIndustrialProduct1Choice_ { }
}
