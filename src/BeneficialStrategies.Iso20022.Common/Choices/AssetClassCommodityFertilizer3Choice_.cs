// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is fertilizer.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Ammonia))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.DiammoniumPhosphate))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Potash))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Sulphur))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Urea))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.UreaAndAmmoniumNitrate))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Ammonia),nameof(AssetClassCommodityFertilizer3Choice.Ammonia))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.DiammoniumPhosphate),nameof(AssetClassCommodityFertilizer3Choice.DiammoniumPhosphate))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Potash),nameof(AssetClassCommodityFertilizer3Choice.Potash))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Sulphur),nameof(AssetClassCommodityFertilizer3Choice.Sulphur))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Urea),nameof(AssetClassCommodityFertilizer3Choice.Urea))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.UreaAndAmmoniumNitrate),nameof(AssetClassCommodityFertilizer3Choice.UreaAndAmmoniumNitrate))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Other),nameof(AssetClassCommodityFertilizer3Choice.Other))]
    [IsoId("_K19uYbv7EeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Fertilizer 3 Choice")]
    public abstract partial record AssetClassCommodityFertilizer3Choice_
    {
    }
}
