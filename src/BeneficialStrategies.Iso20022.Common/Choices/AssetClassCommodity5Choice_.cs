// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define commodity specific attributes of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassCommodity5Choice.Agricultural))]
    [KnownType(typeof(AssetClassCommodity5Choice.Energy))]
    [KnownType(typeof(AssetClassCommodity5Choice.Environmental))]
    [KnownType(typeof(AssetClassCommodity5Choice.Fertilizer))]
    [KnownType(typeof(AssetClassCommodity5Choice.Freight))]
    [KnownType(typeof(AssetClassCommodity5Choice.IndustrialProduct))]
    [KnownType(typeof(AssetClassCommodity5Choice.Metal))]
    [KnownType(typeof(AssetClassCommodity5Choice.OtherC10))]
    [KnownType(typeof(AssetClassCommodity5Choice.Paper))]
    [KnownType(typeof(AssetClassCommodity5Choice.Polypropylene))]
    [KnownType(typeof(AssetClassCommodity5Choice.Inflation))]
    [KnownType(typeof(AssetClassCommodity5Choice.MultiCommodityExotic))]
    [KnownType(typeof(AssetClassCommodity5Choice.OfficialEconomicStatistics))]
    [KnownType(typeof(AssetClassCommodity5Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Agricultural),
        nameof(AssetClassCommodity5Choice.Agricultural)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Energy),
        nameof(AssetClassCommodity5Choice.Energy)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Environmental),
        nameof(AssetClassCommodity5Choice.Environmental)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Fertilizer),
        nameof(AssetClassCommodity5Choice.Fertilizer)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Freight),
        nameof(AssetClassCommodity5Choice.Freight)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.IndustrialProduct),
        nameof(AssetClassCommodity5Choice.IndustrialProduct)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Metal),
        nameof(AssetClassCommodity5Choice.Metal)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.OtherC10),
        nameof(AssetClassCommodity5Choice.OtherC10)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Paper),
        nameof(AssetClassCommodity5Choice.Paper)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Polypropylene),
        nameof(AssetClassCommodity5Choice.Polypropylene)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Inflation),
        nameof(AssetClassCommodity5Choice.Inflation)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.MultiCommodityExotic),
        nameof(AssetClassCommodity5Choice.MultiCommodityExotic)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.OfficialEconomicStatistics),
        nameof(AssetClassCommodity5Choice.OfficialEconomicStatistics)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity5Choice.Other),
        nameof(AssetClassCommodity5Choice.Other)
    )]
    [IsoId("_omaPsbtIEeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity 5 Choice")]
    public abstract record AssetClassCommodity5Choice_ { }
}
