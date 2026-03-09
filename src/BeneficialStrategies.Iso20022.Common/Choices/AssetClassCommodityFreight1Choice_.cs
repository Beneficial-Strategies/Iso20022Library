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
    /// Defines commodity attributes of a derivative where the type is freight.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityFreight1Choice.Dry))]
    [KnownType(typeof(AssetClassCommodityFreight1Choice.Wet))]
    [KnownType(typeof(AssetClassCommodityFreight1Choice.ContainerShip))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityFreight1Choice.Dry),nameof(AssetClassCommodityFreight1Choice.Dry))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight1Choice.Wet),nameof(AssetClassCommodityFreight1Choice.Wet))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight1Choice.ContainerShip),nameof(AssetClassCommodityFreight1Choice.ContainerShip))]
    #endif
    [IsoId("_35TWUFrXEeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Freight 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityFreight1Choice_
    #else
    public abstract partial class AssetClassCommodityFreight1Choice_
    #endif
    {
    }
}
