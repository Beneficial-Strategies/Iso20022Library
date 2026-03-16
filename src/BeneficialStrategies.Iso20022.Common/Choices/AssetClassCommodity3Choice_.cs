// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define commodity specific attributes of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassCommodity3Choice.Agricultural))]
    [KnownType(typeof(AssetClassCommodity3Choice.Energy))]
    [KnownType(typeof(AssetClassCommodity3Choice.Environmental))]
    [KnownType(typeof(AssetClassCommodity3Choice.Fertilizer))]
    [KnownType(typeof(AssetClassCommodity3Choice.Freight))]
    [KnownType(typeof(AssetClassCommodity3Choice.IndustrialProduct))]
    [KnownType(typeof(AssetClassCommodity3Choice.Metal))]
    [KnownType(typeof(AssetClassCommodity3Choice.OtherC10))]
    [KnownType(typeof(AssetClassCommodity3Choice.Paper))]
    [KnownType(typeof(AssetClassCommodity3Choice.Polypropylene))]
    [KnownType(typeof(AssetClassCommodity3Choice.Inflation))]
    [KnownType(typeof(AssetClassCommodity3Choice.MultiCommodityExotic))]
    [KnownType(typeof(AssetClassCommodity3Choice.OfficialEconomicStatistics))]
    [KnownType(typeof(AssetClassCommodity3Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Agricultural),
        nameof(AssetClassCommodity3Choice.Agricultural)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Energy),
        nameof(AssetClassCommodity3Choice.Energy)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Environmental),
        nameof(AssetClassCommodity3Choice.Environmental)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Fertilizer),
        nameof(AssetClassCommodity3Choice.Fertilizer)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Freight),
        nameof(AssetClassCommodity3Choice.Freight)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.IndustrialProduct),
        nameof(AssetClassCommodity3Choice.IndustrialProduct)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Metal),
        nameof(AssetClassCommodity3Choice.Metal)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.OtherC10),
        nameof(AssetClassCommodity3Choice.OtherC10)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Paper),
        nameof(AssetClassCommodity3Choice.Paper)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Polypropylene),
        nameof(AssetClassCommodity3Choice.Polypropylene)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Inflation),
        nameof(AssetClassCommodity3Choice.Inflation)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.MultiCommodityExotic),
        nameof(AssetClassCommodity3Choice.MultiCommodityExotic)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.OfficialEconomicStatistics),
        nameof(AssetClassCommodity3Choice.OfficialEconomicStatistics)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity3Choice.Other),
        nameof(AssetClassCommodity3Choice.Other)
    )]
    [IsoId("_lKiggXvyEeanCNPcMT7sSg")]
    [DisplayName("Asset Class Commodity 3 Choice")]
    public abstract record AssetClassCommodity3Choice_ { }
}
