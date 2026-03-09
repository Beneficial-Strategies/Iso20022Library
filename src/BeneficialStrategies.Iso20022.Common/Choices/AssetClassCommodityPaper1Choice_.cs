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
    [KnownType(typeof(AssetClassCommodityPaper1Choice.ContainerBoard))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.Newsprint))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.Pulp))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.RecoveredPaper))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.ContainerBoard),nameof(AssetClassCommodityPaper1Choice.ContainerBoard))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.Newsprint),nameof(AssetClassCommodityPaper1Choice.Newsprint))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.Pulp),nameof(AssetClassCommodityPaper1Choice.Pulp))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.RecoveredPaper),nameof(AssetClassCommodityPaper1Choice.RecoveredPaper))]
    #endif
    [IsoId("_0bsBIFrxEeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Paper 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AssetClassCommodityPaper1Choice_
    #else
    public abstract partial class AssetClassCommodityPaper1Choice_
    #endif
    {
    }
}
