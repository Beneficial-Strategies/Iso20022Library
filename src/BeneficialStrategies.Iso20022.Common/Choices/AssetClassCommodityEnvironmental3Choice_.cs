// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is environmental.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Emissions))]
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Weather))]
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.CarbonRelated))]
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.Emissions),nameof(AssetClassCommodityEnvironmental3Choice.Emissions))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.Weather),nameof(AssetClassCommodityEnvironmental3Choice.Weather))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.CarbonRelated),nameof(AssetClassCommodityEnvironmental3Choice.CarbonRelated))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.Other),nameof(AssetClassCommodityEnvironmental3Choice.Other))]
    [IsoId("_9bs7AU8REe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Environmental 3 Choice")]
    public abstract partial record AssetClassCommodityEnvironmental3Choice_
    {
    }
}
