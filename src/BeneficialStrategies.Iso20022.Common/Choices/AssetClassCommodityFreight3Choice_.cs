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
    [KnownType(typeof(AssetClassCommodityFreight3Choice.Dry))]
    [KnownType(typeof(AssetClassCommodityFreight3Choice.Wet))]
    [KnownType(typeof(AssetClassCommodityFreight3Choice.ContainerShip))]
    [KnownType(typeof(AssetClassCommodityFreight3Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.Dry),nameof(AssetClassCommodityFreight3Choice.Dry))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.Wet),nameof(AssetClassCommodityFreight3Choice.Wet))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.ContainerShip),nameof(AssetClassCommodityFreight3Choice.ContainerShip))]
    [JsonDerivedType(typeof(AssetClassCommodityFreight3Choice.Other),nameof(AssetClassCommodityFreight3Choice.Other))]
    #endif
    [IsoId("_VSOj0bv5EeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Freight 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityFreight3Choice_
    #else
    public abstract partial class AssetClassCommodityFreight3Choice_
    #endif
    {
    }
}
