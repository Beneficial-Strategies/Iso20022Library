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
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Electricity))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.NaturalGas))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Oil))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Coal))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.InterEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.RenewableEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.LightEnd))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Distillates))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.Electricity),nameof(AssetClassCommodityEnergy2Choice.Electricity))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.NaturalGas),nameof(AssetClassCommodityEnergy2Choice.NaturalGas))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.Oil),nameof(AssetClassCommodityEnergy2Choice.Oil))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.Coal),nameof(AssetClassCommodityEnergy2Choice.Coal))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.InterEnergy),nameof(AssetClassCommodityEnergy2Choice.InterEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.RenewableEnergy),nameof(AssetClassCommodityEnergy2Choice.RenewableEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.LightEnd),nameof(AssetClassCommodityEnergy2Choice.LightEnd))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.Distillates),nameof(AssetClassCommodityEnergy2Choice.Distillates))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy2Choice.Other),nameof(AssetClassCommodityEnergy2Choice.Other))]
    #endif
    [IsoId("_xupNAbvsEeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Energy 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityEnergy2Choice_
    #else
    public abstract partial class AssetClassCommodityEnergy2Choice_
    #endif
    {
    }
}
