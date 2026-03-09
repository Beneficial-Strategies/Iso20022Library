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
    /// Defines commodity attributes of a derivative where the type is agricultural.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.GrainOilSeed))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.Soft))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.Potato))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.OliveOil))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.Dairy))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.Forestry))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.Seafood))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.LiveStock))]
    [KnownType(typeof(AssetClassCommodityAgricultural1Choice.Grain))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.GrainOilSeed),nameof(AssetClassCommodityAgricultural1Choice.GrainOilSeed))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.Soft),nameof(AssetClassCommodityAgricultural1Choice.Soft))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.Potato),nameof(AssetClassCommodityAgricultural1Choice.Potato))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.OliveOil),nameof(AssetClassCommodityAgricultural1Choice.OliveOil))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.Dairy),nameof(AssetClassCommodityAgricultural1Choice.Dairy))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.Forestry),nameof(AssetClassCommodityAgricultural1Choice.Forestry))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.Seafood),nameof(AssetClassCommodityAgricultural1Choice.Seafood))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.LiveStock),nameof(AssetClassCommodityAgricultural1Choice.LiveStock))]
    [JsonDerivedType(typeof(AssetClassCommodityAgricultural1Choice.Grain),nameof(AssetClassCommodityAgricultural1Choice.Grain))]
    #endif
    [IsoId("_VQFYWw2jEeW72qLtWESimw")]
    [DisplayName("Asset Class Commodity Agricultural 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityAgricultural1Choice_
    #else
    public abstract partial class AssetClassCommodityAgricultural1Choice_
    #endif
    {
    }
}
