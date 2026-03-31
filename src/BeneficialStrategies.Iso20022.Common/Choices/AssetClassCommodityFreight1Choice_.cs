// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is freight.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFreight1Choice.Dry))]
    [KnownType(typeof(AssetClassCommodityFreight1Choice.Wet))]
    [KnownType(typeof(AssetClassCommodityFreight1Choice.ContainerShip))]
    [JsonDerivedType(
        typeof(AssetClassCommodityFreight1Choice.Dry),
        nameof(AssetClassCommodityFreight1Choice.Dry)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFreight1Choice.Wet),
        nameof(AssetClassCommodityFreight1Choice.Wet)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFreight1Choice.ContainerShip),
        nameof(AssetClassCommodityFreight1Choice.ContainerShip)
    )]
    [IsoId("_35TWUFrXEeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Freight 1 Choice")]
    public abstract record AssetClassCommodityFreight1Choice_ { }
}
