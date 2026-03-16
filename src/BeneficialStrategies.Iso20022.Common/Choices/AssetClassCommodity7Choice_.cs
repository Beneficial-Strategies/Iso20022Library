// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Asset Class Commodity7Choice.
    /// </summary>
    [KnownType(typeof(AssetClassCommodity7Choice.Agricultural))]
    [KnownType(typeof(AssetClassCommodity7Choice.Energy))]
    [KnownType(typeof(AssetClassCommodity7Choice.Environmental))]
    [KnownType(typeof(AssetClassCommodity7Choice.Fertilizer))]
    [KnownType(typeof(AssetClassCommodity7Choice.Freight))]
    [KnownType(typeof(AssetClassCommodity7Choice.Index))]
    [KnownType(typeof(AssetClassCommodity7Choice.IndustrialProduct))]
    [KnownType(typeof(AssetClassCommodity7Choice.Inflation))]
    [KnownType(typeof(AssetClassCommodity7Choice.Metal))]
    [KnownType(typeof(AssetClassCommodity7Choice.MultiCommodityExotic))]
    [KnownType(typeof(AssetClassCommodity7Choice.OfficialEconomicStatistics))]
    [KnownType(typeof(AssetClassCommodity7Choice.Other))]
    [KnownType(typeof(AssetClassCommodity7Choice.OtherC10))]
    [KnownType(typeof(AssetClassCommodity7Choice.Paper))]
    [KnownType(typeof(AssetClassCommodity7Choice.Polypropylene))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Agricultural),nameof(AssetClassCommodity7Choice.Agricultural))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Energy),nameof(AssetClassCommodity7Choice.Energy))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Environmental),nameof(AssetClassCommodity7Choice.Environmental))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Fertilizer),nameof(AssetClassCommodity7Choice.Fertilizer))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Freight),nameof(AssetClassCommodity7Choice.Freight))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Index),nameof(AssetClassCommodity7Choice.Index))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.IndustrialProduct),nameof(AssetClassCommodity7Choice.IndustrialProduct))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Inflation),nameof(AssetClassCommodity7Choice.Inflation))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Metal),nameof(AssetClassCommodity7Choice.Metal))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.MultiCommodityExotic),nameof(AssetClassCommodity7Choice.MultiCommodityExotic))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.OfficialEconomicStatistics),nameof(AssetClassCommodity7Choice.OfficialEconomicStatistics))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Other),nameof(AssetClassCommodity7Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.OtherC10),nameof(AssetClassCommodity7Choice.OtherC10))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Paper),nameof(AssetClassCommodity7Choice.Paper))]
    [JsonDerivedType(typeof(AssetClassCommodity7Choice.Polypropylene),nameof(AssetClassCommodity7Choice.Polypropylene))]
    [IsoId("_8u1sYY-REe6Ojt1b3tfu9Q")]
    [DisplayName("Asset Class Commodity7Choice")]
    public abstract partial record AssetClassCommodity7Choice_
    {
    }
}
