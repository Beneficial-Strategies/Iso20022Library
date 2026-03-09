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
    /// Defines commodity attributes of a derivative where the type is paper.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPaper4Choice.ContainerBoard))]
    [KnownType(typeof(AssetClassCommodityPaper4Choice.Newsprint))]
    [KnownType(typeof(AssetClassCommodityPaper4Choice.Pulp))]
    [KnownType(typeof(AssetClassCommodityPaper4Choice.RecoveredPaper))]
    [KnownType(typeof(AssetClassCommodityPaper4Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityPaper4Choice.ContainerBoard),nameof(AssetClassCommodityPaper4Choice.ContainerBoard))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper4Choice.Newsprint),nameof(AssetClassCommodityPaper4Choice.Newsprint))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper4Choice.Pulp),nameof(AssetClassCommodityPaper4Choice.Pulp))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper4Choice.RecoveredPaper),nameof(AssetClassCommodityPaper4Choice.RecoveredPaper))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper4Choice.Other),nameof(AssetClassCommodityPaper4Choice.Other))]
    #endif
    [IsoId("_Frp24RZaEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity Paper 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityPaper4Choice_
    #else
    public abstract partial class AssetClassCommodityPaper4Choice_
    #endif
    {
    }
}
