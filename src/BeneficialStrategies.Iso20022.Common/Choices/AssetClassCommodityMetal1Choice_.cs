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
    /// Defines commodity attributes of a derivative where the type is metal.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityMetal1Choice.NonPrecious))]
    [KnownType(typeof(AssetClassCommodityMetal1Choice.Precious))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityMetal1Choice.NonPrecious),nameof(AssetClassCommodityMetal1Choice.NonPrecious))]
    [JsonDerivedType(typeof(AssetClassCommodityMetal1Choice.Precious),nameof(AssetClassCommodityMetal1Choice.Precious))]
    #endif
    [IsoId("_D1rdUw2rEeW72qLtWESimw")]
    [DisplayName("Asset Class Commodity Metal 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityMetal1Choice_
    #else
    public abstract partial class AssetClassCommodityMetal1Choice_
    #endif
    {
    }
}
