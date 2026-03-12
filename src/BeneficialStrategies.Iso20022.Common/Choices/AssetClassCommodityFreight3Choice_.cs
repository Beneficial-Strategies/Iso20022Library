// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is freight.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFreight3Choice.Dry))]
    [KnownType(typeof(AssetClassCommodityFreight3Choice.Wet))]
    [KnownType(typeof(AssetClassCommodityFreight3Choice.ContainerShip))]
    [KnownType(typeof(AssetClassCommodityFreight3Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.Dry),nameof(AssetClassCommodityFreight3Choice.Dry))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.Wet),nameof(AssetClassCommodityFreight3Choice.Wet))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.ContainerShip),nameof(AssetClassCommodityFreight3Choice.ContainerShip))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.Other),nameof(AssetClassCommodityFreight3Choice.Other))]
    [IsoId("_VSOj0bv5EeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Freight 3 Choice")]
    public abstract partial record AssetClassCommodityFreight3Choice_
    {
    }
}
