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
    /// Defines commodity attributes of a derivative where the type is other C10.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityOtherC102Choice.Deliverable))]
    [KnownType(typeof(AssetClassCommodityOtherC102Choice.NonDeliverable))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityOtherC102Choice.Deliverable),nameof(AssetClassCommodityOtherC102Choice.Deliverable))]
    [JsonDerivedType(typeof(AssetClassCommodityOtherC102Choice.NonDeliverable),nameof(AssetClassCommodityOtherC102Choice.NonDeliverable))]
    #endif
    [IsoId("_lTiEcXvyEeanCNPcMT7sSg")]
    [DisplayName("Asset Class Commodity Other C 102 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityOtherC102Choice_
    #else
    public abstract partial class AssetClassCommodityOtherC102Choice_
    #endif
    {
    }
}
