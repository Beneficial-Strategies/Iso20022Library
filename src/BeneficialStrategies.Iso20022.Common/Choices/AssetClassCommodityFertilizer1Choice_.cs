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
    /// Defines commodity attributes of a derivative where the type is fertilizer.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Ammonia))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Potash))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Sulphur))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.Urea))]
    [KnownType(typeof(AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer1Choice.Ammonia),nameof(AssetClassCommodityFertilizer1Choice.Ammonia))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate),nameof(AssetClassCommodityFertilizer1Choice.DiammoniumPhosphate))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer1Choice.Potash),nameof(AssetClassCommodityFertilizer1Choice.Potash))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer1Choice.Sulphur),nameof(AssetClassCommodityFertilizer1Choice.Sulphur))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer1Choice.Urea),nameof(AssetClassCommodityFertilizer1Choice.Urea))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate),nameof(AssetClassCommodityFertilizer1Choice.UreaAndAmmoniumNitrate))]
    #endif
    [IsoId("_J_XoMFr2EeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Fertilizer 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityFertilizer1Choice_
    #else
    public abstract partial class AssetClassCommodityFertilizer1Choice_
    #endif
    {
    }
}
