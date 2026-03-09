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
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.Emissions))]
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.Weather))]
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.CarbonRelated))]
    [KnownType(typeof(AssetClassCommodityEnvironmental2Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental2Choice.Emissions),nameof(AssetClassCommodityEnvironmental2Choice.Emissions))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental2Choice.Weather),nameof(AssetClassCommodityEnvironmental2Choice.Weather))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental2Choice.CarbonRelated),nameof(AssetClassCommodityEnvironmental2Choice.CarbonRelated))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental2Choice.Other),nameof(AssetClassCommodityEnvironmental2Choice.Other))]
    #endif
    [IsoId("_gyGPgbvwEeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Environmental 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityEnvironmental2Choice_
    #else
    public abstract partial class AssetClassCommodityEnvironmental2Choice_
    #endif
    {
    }
}
