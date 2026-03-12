// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is paper.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPaper1Choice.ContainerBoard))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.Newsprint))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.Pulp))]
    [KnownType(typeof(AssetClassCommodityPaper1Choice.RecoveredPaper))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.ContainerBoard),nameof(AssetClassCommodityPaper1Choice.ContainerBoard))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.Newsprint),nameof(AssetClassCommodityPaper1Choice.Newsprint))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.Pulp),nameof(AssetClassCommodityPaper1Choice.Pulp))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper1Choice.RecoveredPaper),nameof(AssetClassCommodityPaper1Choice.RecoveredPaper))]
    [IsoId("_0bsBIFrxEeWN79Bl6BUd3g")]
    [DisplayName("Asset Class Commodity Paper 1 Choice")]
    public abstract partial record AssetClassCommodityPaper1Choice_
    {
    }
}
