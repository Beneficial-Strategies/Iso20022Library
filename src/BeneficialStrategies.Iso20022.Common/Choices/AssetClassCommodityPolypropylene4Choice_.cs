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
    /// Defines commodity attributes of a derivative where the type is polypropylene.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPolypropylene4Choice.Plastic))]
    [KnownType(typeof(AssetClassCommodityPolypropylene4Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityPolypropylene4Choice.Plastic),nameof(AssetClassCommodityPolypropylene4Choice.Plastic))]
    [JsonDerivedType(typeof(AssetClassCommodityPolypropylene4Choice.Other),nameof(AssetClassCommodityPolypropylene4Choice.Other))]
    #endif
    [IsoId("_yRdvERZZEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity Polypropylene 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityPolypropylene4Choice_
    #else
    public abstract partial class AssetClassCommodityPolypropylene4Choice_
    #endif
    {
    }
}
