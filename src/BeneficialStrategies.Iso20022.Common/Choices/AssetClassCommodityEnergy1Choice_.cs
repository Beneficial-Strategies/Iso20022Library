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
    /// Defines commodity attributes of a derivative where the type is energy.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Electricity))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.NaturalGas))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Oil))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Coal))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.InterEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.RenewableEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.LightEnd))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Distillates))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Electricity),nameof(AssetClassCommodityEnergy1Choice.Electricity))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.NaturalGas),nameof(AssetClassCommodityEnergy1Choice.NaturalGas))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Oil),nameof(AssetClassCommodityEnergy1Choice.Oil))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Coal),nameof(AssetClassCommodityEnergy1Choice.Coal))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.InterEnergy),nameof(AssetClassCommodityEnergy1Choice.InterEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.RenewableEnergy),nameof(AssetClassCommodityEnergy1Choice.RenewableEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.LightEnd),nameof(AssetClassCommodityEnergy1Choice.LightEnd))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Distillates),nameof(AssetClassCommodityEnergy1Choice.Distillates))]
    #endif
    [IsoId("_pBoTZg2nEeW72qLtWESimw")]
    [DisplayName("Asset Class Commodity Energy 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityEnergy1Choice_
    #else
    public abstract partial class AssetClassCommodityEnergy1Choice_
    #endif
    {
    }
}
