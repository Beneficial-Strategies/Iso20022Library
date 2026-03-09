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
    [KnownType(typeof(AssetClassCommodityIndustrialProduct2Choice.Construction))]
    [KnownType(typeof(AssetClassCommodityIndustrialProduct2Choice.Manufacturing))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityIndustrialProduct2Choice.Construction),nameof(AssetClassCommodityIndustrialProduct2Choice.Construction))]
    [JsonDerivedType(typeof(AssetClassCommodityIndustrialProduct2Choice.Manufacturing),nameof(AssetClassCommodityIndustrialProduct2Choice.Manufacturing))]
    #endif
    [IsoId("_OS8SQRZZEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity Industrial Product 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityIndustrialProduct2Choice_
    #else
    public abstract partial class AssetClassCommodityIndustrialProduct2Choice_
    #endif
    {
    }
}
