// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is paper.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPaper3Choice.ContainerBoard))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.Newsprint))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.Pulp))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.RecoveredPaper))]
    [KnownType(typeof(AssetClassCommodityPaper3Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper3Choice.ContainerBoard),
        nameof(AssetClassCommodityPaper3Choice.ContainerBoard)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper3Choice.Newsprint),
        nameof(AssetClassCommodityPaper3Choice.Newsprint)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper3Choice.Pulp),
        nameof(AssetClassCommodityPaper3Choice.Pulp)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper3Choice.RecoveredPaper),
        nameof(AssetClassCommodityPaper3Choice.RecoveredPaper)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper3Choice.Other),
        nameof(AssetClassCommodityPaper3Choice.Other)
    )]
    [IsoId("__d2KIbv7EeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Paper 3 Choice")]
    public abstract record AssetClassCommodityPaper3Choice_ { }
}
