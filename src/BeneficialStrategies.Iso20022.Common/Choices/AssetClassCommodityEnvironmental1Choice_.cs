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
    [KnownType(typeof(AssetClassCommodityEnvironmental1Choice.Emissions))]
    [KnownType(typeof(AssetClassCommodityEnvironmental1Choice.Weather))]
    [KnownType(typeof(AssetClassCommodityEnvironmental1Choice.CarbonRelated))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental1Choice.Emissions),nameof(AssetClassCommodityEnvironmental1Choice.Emissions))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental1Choice.Weather),nameof(AssetClassCommodityEnvironmental1Choice.Weather))]
    [JsonDerivedType(typeof(AssetClassCommodityEnvironmental1Choice.CarbonRelated),nameof(AssetClassCommodityEnvironmental1Choice.CarbonRelated))]
    #endif
    [IsoId("_aQGG1Q2pEeW72qLtWESimw")]
    [DisplayName("Asset Class Commodity Environmental 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityEnvironmental1Choice_
    #else
    public abstract partial class AssetClassCommodityEnvironmental1Choice_
    #endif
    {
    }
}
