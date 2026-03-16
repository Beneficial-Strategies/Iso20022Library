// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is fertilizer.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Ammonia))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Potash))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Sulphur))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Urea))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate))]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer1Choice.Ammonia),
        nameof(AssetClassCommodityFertilizer1Choice.Ammonia)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate),
        nameof(AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer1Choice.Potash),
        nameof(AssetClassCommodityFertilizer1Choice.Potash)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer1Choice.Sulphur),
        nameof(AssetClassCommodityFertilizer1Choice.Sulphur)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer1Choice.Urea),
        nameof(AssetClassCommodityFertilizer1Choice.Urea)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate),
        nameof(AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate)
    )]
    [IsoId("_J_XoMFr2EeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Fertilizer 1 Choice")]
    public abstract record AssetClassCommodityFertilizer1Choice_ { }
}
