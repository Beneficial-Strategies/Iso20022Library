// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is agricultural.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.GrainOilSeed))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.Soft))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.Potato))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.OliveOil))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.Dairy))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.Forestry))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.Seafood))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.LiveStock))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.Grain))]
    [KnownType(typeof(AssetClassCommodityAgricultural6Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.GrainOilSeed),nameof(AssetClassCommodityAgricultural6Choice.GrainOilSeed))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.Soft),nameof(AssetClassCommodityAgricultural6Choice.Soft))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.Potato),nameof(AssetClassCommodityAgricultural6Choice.Potato))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.OliveOil),nameof(AssetClassCommodityAgricultural6Choice.OliveOil))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.Dairy),nameof(AssetClassCommodityAgricultural6Choice.Dairy))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.Forestry),nameof(AssetClassCommodityAgricultural6Choice.Forestry))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.Seafood),nameof(AssetClassCommodityAgricultural6Choice.Seafood))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.LiveStock),nameof(AssetClassCommodityAgricultural6Choice.LiveStock))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.Grain),nameof(AssetClassCommodityAgricultural6Choice.Grain))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural6Choice.Other),nameof(AssetClassCommodityAgricultural6Choice.Other))]
    [IsoId("_xGI3EU8SEe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Agricultural 6 Choice")]
    public abstract partial record AssetClassCommodityAgricultural6Choice_
    {
    }
}
