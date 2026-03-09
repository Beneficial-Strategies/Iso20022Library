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
    /// Defines commodity attributes of a derivative where the type is industrial product.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityIndustrialProduct1Choice.Construction))]
    [KnownType(typeof(AssetClassCommodityIndustrialProduct1Choice.Manufacturing))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityIndustrialProduct1Choice.Construction),nameof(AssetClassCommodityIndustrialProduct1Choice.Construction))]
    [JsonDerivedType(typeof(AssetClassCommodityIndustrialProduct1Choice.Manufacturing),nameof(AssetClassCommodityIndustrialProduct1Choice.Manufacturing))]
    #endif
    [IsoId("_5jkmIFrfEeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Industrial Product 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityIndustrialProduct1Choice_
    #else
    public abstract partial class AssetClassCommodityIndustrialProduct1Choice_
    #endif
    {
    }
}
