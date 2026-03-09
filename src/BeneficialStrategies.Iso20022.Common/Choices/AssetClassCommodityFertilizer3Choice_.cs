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
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Ammonia))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.DiammoniumPhosphate))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Potash))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Sulphur))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Urea))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.UreaAndAmmoniumNitrate))]
    [KnownType(typeof(AssetClassCommodityFertilizer3Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Ammonia),nameof(AssetClassCommodityFertilizer3Choice.Ammonia))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.DiammoniumPhosphate),nameof(AssetClassCommodityFertilizer3Choice.DiammoniumPhosphate))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Potash),nameof(AssetClassCommodityFertilizer3Choice.Potash))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Sulphur),nameof(AssetClassCommodityFertilizer3Choice.Sulphur))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Urea),nameof(AssetClassCommodityFertilizer3Choice.Urea))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.UreaAndAmmoniumNitrate),nameof(AssetClassCommodityFertilizer3Choice.UreaAndAmmoniumNitrate))]
    [JsonDerivedType(typeof(AssetClassCommodityFertilizer3Choice.Other),nameof(AssetClassCommodityFertilizer3Choice.Other))]
    #endif
    [IsoId("_K19uYbv7EeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Fertilizer 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityFertilizer3Choice_
    #else
    public abstract partial class AssetClassCommodityFertilizer3Choice_
    #endif
    {
    }
}
