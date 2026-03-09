// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Agricultural),nameof(AssetClassCommodity5Choice.Agricultural))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Energy),nameof(AssetClassCommodity5Choice.Energy))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Environmental),nameof(AssetClassCommodity5Choice.Environmental))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Fertilizer),nameof(AssetClassCommodity5Choice.Fertilizer))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Freight),nameof(AssetClassCommodity5Choice.Freight))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.IndustrialProduct),nameof(AssetClassCommodity5Choice.IndustrialProduct))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Metal),nameof(AssetClassCommodity5Choice.Metal))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.OtherC10),nameof(AssetClassCommodity5Choice.OtherC10))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Paper),nameof(AssetClassCommodity5Choice.Paper))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Polypropylene),nameof(AssetClassCommodity5Choice.Polypropylene))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Inflation),nameof(AssetClassCommodity5Choice.Inflation))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.MultiCommodityExotic),nameof(AssetClassCommodity5Choice.MultiCommodityExotic))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.OfficialEconomicStatistics),nameof(AssetClassCommodity5Choice.OfficialEconomicStatistics))]
    [JsonDerivedType(typeof(AssetClassCommodity5Choice.Other),nameof(AssetClassCommodity5Choice.Other))]
    #endif
    [IsoId("_omaPsbtIEeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodity5Choice_
    #else
    public abstract partial class AssetClassCommodity5Choice_
    #endif
    {
    }
}
