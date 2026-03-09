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
    [KnownType(typeof(AssetClassCommodityFreight4Choice.Dry))]
    [KnownType(typeof(AssetClassCommodityFreight4Choice.Wet))]
    [KnownType(typeof(AssetClassCommodityFreight4Choice.ContainerShip))]
    [KnownType(typeof(AssetClassCommodityFreight4Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.Dry),nameof(AssetClassCommodityFreight4Choice.Dry))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.Wet),nameof(AssetClassCommodityFreight4Choice.Wet))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.ContainerShip),nameof(AssetClassCommodityFreight4Choice.ContainerShip))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight4Choice.Other),nameof(AssetClassCommodityFreight4Choice.Other))]
    #endif
    [IsoId("_RnG50U8REe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Freight 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityFreight4Choice_
    #else
    public abstract partial class AssetClassCommodityFreight4Choice_
    #endif
    {
    }
}
