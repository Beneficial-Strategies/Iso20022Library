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
    /// Defines commodity attributes of a derivative where the type is environmental.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Emissions))]
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Weather))]
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.CarbonRelated))]
    [KnownType(typeof(AssetClassCommodityEnvironmental3Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.Emissions),nameof(AssetClassCommodityEnvironmental3Choice.Emissions))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.Weather),nameof(AssetClassCommodityEnvironmental3Choice.Weather))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.CarbonRelated),nameof(AssetClassCommodityEnvironmental3Choice.CarbonRelated))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental3Choice.Other),nameof(AssetClassCommodityEnvironmental3Choice.Other))]
    #endif
    [IsoId("_9bs7AU8REe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Environmental 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityEnvironmental3Choice_
    #else
    public abstract partial class AssetClassCommodityEnvironmental3Choice_
    #endif
    {
    }
}
