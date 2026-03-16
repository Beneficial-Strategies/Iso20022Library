// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Asset Class Commodity Paper5Choice.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPaper5Choice.ContainerBoard))]
    [KnownType(typeof(AssetClassCommodityPaper5Choice.Newsprint))]
    [KnownType(typeof(AssetClassCommodityPaper5Choice.Other))]
    [KnownType(typeof(AssetClassCommodityPaper5Choice.Pulp))]
    [KnownType(typeof(AssetClassCommodityPaper5Choice.RecoveredPaper))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper5Choice.ContainerBoard),nameof(AssetClassCommodityPaper5Choice.ContainerBoard))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper5Choice.Newsprint),nameof(AssetClassCommodityPaper5Choice.Newsprint))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper5Choice.Other),nameof(AssetClassCommodityPaper5Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper5Choice.Pulp),nameof(AssetClassCommodityPaper5Choice.Pulp))]
    [JsonDerivedType(typeof(AssetClassCommodityPaper5Choice.RecoveredPaper),nameof(AssetClassCommodityPaper5Choice.RecoveredPaper))]
    [IsoId("_8vudMY-REe6Ojt1b3tfu9Q")]
    [DisplayName("Asset Class Commodity Paper5Choice")]
    public abstract partial record AssetClassCommodityPaper5Choice_
    {
    }
}
