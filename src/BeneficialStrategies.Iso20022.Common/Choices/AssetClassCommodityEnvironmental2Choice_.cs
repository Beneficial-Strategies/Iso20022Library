// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is environmental.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.Emissions))]
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.Weather))]
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.CarbonRelated))]
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnvironmental2Choice.Emissions),
        nameof(AssetClassCommodityEnvironmental2Choice.Emissions)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnvironmental2Choice.Weather),
        nameof(AssetClassCommodityEnvironmental2Choice.Weather)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnvironmental2Choice.CarbonRelated),
        nameof(AssetClassCommodityEnvironmental2Choice.CarbonRelated)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnvironmental2Choice.Other),
        nameof(AssetClassCommodityEnvironmental2Choice.Other)
    )]
    [IsoId("_gyGPgbvwEeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Environmental 2 Choice")]
    public abstract record AssetClassCommodityEnvironmental2Choice_ { }
}
