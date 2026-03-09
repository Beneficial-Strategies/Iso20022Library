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
    /// Defines commodity specific attributes of a derivative.
    /// </summary>
    [KnownType(typeof(AssetClassCommodity2Choice.Agricultural))]
    [KnownType(typeof(AssetClassCommodity2Choice.Energy))]
    [KnownType(typeof(AssetClassCommodity2Choice.Environmental))]
    [KnownType(typeof(AssetClassCommodity2Choice.Freight))]
    [KnownType(typeof(AssetClassCommodity2Choice.Index))]
    [KnownType(typeof(AssetClassCommodity2Choice.Metal))]
    [KnownType(typeof(AssetClassCommodity2Choice.Exotic))]
    [KnownType(typeof(AssetClassCommodity2Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Agricultural),nameof(AssetClassCommodity2Choice.Agricultural))]
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Energy),nameof(AssetClassCommodity2Choice.Energy))]
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Environmental),nameof(AssetClassCommodity2Choice.Environmental))]
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Freight),nameof(AssetClassCommodity2Choice.Freight))]
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Index),nameof(AssetClassCommodity2Choice.Index))]
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Metal),nameof(AssetClassCommodity2Choice.Metal))]
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Exotic),nameof(AssetClassCommodity2Choice.Exotic))]
    [JsonDerivedType(typeof(AssetClassCommodity2Choice.Other),nameof(AssetClassCommodity2Choice.Other))]
    #endif
    [IsoId("_BzEmOCYyEeWHeosc_5RQEw")]
    [DisplayName("Asset Class Commodity 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodity2Choice_
    #else
    public abstract partial class AssetClassCommodity2Choice_
    #endif
    {
    }
}
