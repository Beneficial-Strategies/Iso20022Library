// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is freight.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFreight4Choice.Dry))]
    [KnownType(typeof(AssetClassCommodityFreight4Choice.Wet))]
    [KnownType(typeof(AssetClassCommodityFreight4Choice.ContainerShip))]
    [KnownType(typeof(AssetClassCommodityFreight4Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.Dry),nameof(AssetClassCommodityFreight4Choice.Dry))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.Wet),nameof(AssetClassCommodityFreight4Choice.Wet))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.ContainerShip),nameof(AssetClassCommodityFreight4Choice.ContainerShip))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.Other),nameof(AssetClassCommodityFreight4Choice.Other))]
    [IsoId("_RnG50U8REe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Freight 4 Choice")]
    public abstract partial record AssetClassCommodityFreight4Choice_
    {
    }
}
