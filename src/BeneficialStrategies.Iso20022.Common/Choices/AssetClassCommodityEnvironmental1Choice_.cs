// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is environmental.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnvironmental1Choice.Emissions))]
    [KnownType(typeof(AssetClassCommodityEnvironmental1Choice.Weather))]
    [KnownType(typeof(AssetClassCommodityEnvironmental1Choice.CarbonRelated))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental1Choice.Emissions),nameof(AssetClassCommodityEnvironmental1Choice.Emissions))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental1Choice.Weather),nameof(AssetClassCommodityEnvironmental1Choice.Weather))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental1Choice.CarbonRelated),nameof(AssetClassCommodityEnvironmental1Choice.CarbonRelated))]
    [IsoId("_aQGG1Q2pEeW72qLtWESimw")]
    [DisplayName("Asset Class Commodity Environmental 1 Choice")]
    public abstract partial record AssetClassCommodityEnvironmental1Choice_
    {
    }
}
