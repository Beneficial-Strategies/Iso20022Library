// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is fertilizer.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Ammonia))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.DiammoniumPhosphate))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Potash))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Sulphur))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Urea))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.UreaAndAmmoniumNitrate))]
    [KnownType(typeof(AssetClassCommodityFertilizer4Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer4Choice.Ammonia),
        nameof(AssetClassCommodityFertilizer4Choice.Ammonia)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer4Choice.DiammoniumPhosphate),
        nameof(AssetClassCommodityFertilizer4Choice.DiammoniumPhosphate)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer4Choice.Potash),
        nameof(AssetClassCommodityFertilizer4Choice.Potash)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer4Choice.Sulphur),
        nameof(AssetClassCommodityFertilizer4Choice.Sulphur)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer4Choice.Urea),
        nameof(AssetClassCommodityFertilizer4Choice.Urea)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer4Choice.UreaAndAmmoniumNitrate),
        nameof(AssetClassCommodityFertilizer4Choice.UreaAndAmmoniumNitrate)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer4Choice.Other),
        nameof(AssetClassCommodityFertilizer4Choice.Other)
    )]
    [IsoId("_icwoUU8REe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Fertilizer 4 Choice")]
    public abstract record AssetClassCommodityFertilizer4Choice_ { }
}
