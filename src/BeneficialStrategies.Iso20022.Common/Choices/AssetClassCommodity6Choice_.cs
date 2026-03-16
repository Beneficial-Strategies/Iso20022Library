// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to define commodity specific attributes of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassCommodity6Choice.Agricultural))]
    [KnownType(typeof(AssetClassCommodity6Choice.Energy))]
    [KnownType(typeof(AssetClassCommodity6Choice.Environmental))]
    [KnownType(typeof(AssetClassCommodity6Choice.Fertilizer))]
    [KnownType(typeof(AssetClassCommodity6Choice.Freight))]
    [KnownType(typeof(AssetClassCommodity6Choice.Index))]
    [KnownType(typeof(AssetClassCommodity6Choice.IndustrialProduct))]
    [KnownType(typeof(AssetClassCommodity6Choice.Inflation))]
    [KnownType(typeof(AssetClassCommodity6Choice.Metal))]
    [KnownType(typeof(AssetClassCommodity6Choice.MultiCommodityExotic))]
    [KnownType(typeof(AssetClassCommodity6Choice.OfficialEconomicStatistics))]
    [KnownType(typeof(AssetClassCommodity6Choice.Other))]
    [KnownType(typeof(AssetClassCommodity6Choice.OtherC10))]
    [KnownType(typeof(AssetClassCommodity6Choice.Paper))]
    [KnownType(typeof(AssetClassCommodity6Choice.Polypropylene))]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Agricultural),
        nameof(AssetClassCommodity6Choice.Agricultural)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Energy),
        nameof(AssetClassCommodity6Choice.Energy)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Environmental),
        nameof(AssetClassCommodity6Choice.Environmental)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Fertilizer),
        nameof(AssetClassCommodity6Choice.Fertilizer)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Freight),
        nameof(AssetClassCommodity6Choice.Freight)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Index),
        nameof(AssetClassCommodity6Choice.Index)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.IndustrialProduct),
        nameof(AssetClassCommodity6Choice.IndustrialProduct)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Inflation),
        nameof(AssetClassCommodity6Choice.Inflation)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Metal),
        nameof(AssetClassCommodity6Choice.Metal)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.MultiCommodityExotic),
        nameof(AssetClassCommodity6Choice.MultiCommodityExotic)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.OfficialEconomicStatistics),
        nameof(AssetClassCommodity6Choice.OfficialEconomicStatistics)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Other),
        nameof(AssetClassCommodity6Choice.Other)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.OtherC10),
        nameof(AssetClassCommodity6Choice.OtherC10)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Paper),
        nameof(AssetClassCommodity6Choice.Paper)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity6Choice.Polypropylene),
        nameof(AssetClassCommodity6Choice.Polypropylene)
    )]
    [IsoId("_1anjQRZXEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity 6 Choice")]
    public abstract record AssetClassCommodity6Choice_ { }
}
