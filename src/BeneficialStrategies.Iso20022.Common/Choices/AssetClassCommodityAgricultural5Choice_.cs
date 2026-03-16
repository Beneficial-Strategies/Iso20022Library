// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is agricultural.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.GrainOilSeed))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.Soft))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.Potato))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.OliveOil))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.Dairy))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.Forestry))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.Seafood))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.LiveStock))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.Grain))]
    [KnownType(typeof(AssetClassCommodityAgricultural5Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.GrainOilSeed),
        nameof(AssetClassCommodityAgricultural5Choice.GrainOilSeed)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.Soft),
        nameof(AssetClassCommodityAgricultural5Choice.Soft)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.Potato),
        nameof(AssetClassCommodityAgricultural5Choice.Potato)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.OliveOil),
        nameof(AssetClassCommodityAgricultural5Choice.OliveOil)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.Dairy),
        nameof(AssetClassCommodityAgricultural5Choice.Dairy)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.Forestry),
        nameof(AssetClassCommodityAgricultural5Choice.Forestry)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.Seafood),
        nameof(AssetClassCommodityAgricultural5Choice.Seafood)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.LiveStock),
        nameof(AssetClassCommodityAgricultural5Choice.LiveStock)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.Grain),
        nameof(AssetClassCommodityAgricultural5Choice.Grain)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityAgricultural5Choice.Other),
        nameof(AssetClassCommodityAgricultural5Choice.Other)
    )]
    [IsoId("_Nm1ZsbveEeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Agricultural 5 Choice")]
    public abstract record AssetClassCommodityAgricultural5Choice_ { }
}
