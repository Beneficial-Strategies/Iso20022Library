// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper4Choice.ContainerBoard),
        nameof(AssetClassCommodityPaper4Choice.ContainerBoard)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper4Choice.Newsprint),
        nameof(AssetClassCommodityPaper4Choice.Newsprint)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper4Choice.Pulp),
        nameof(AssetClassCommodityPaper4Choice.Pulp)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper4Choice.RecoveredPaper),
        nameof(AssetClassCommodityPaper4Choice.RecoveredPaper)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPaper4Choice.Other),
        nameof(AssetClassCommodityPaper4Choice.Other)
    )]
    [IsoId("_Frp24RZaEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity Paper 4 Choice")]
    public abstract record AssetClassCommodityPaper4Choice_ { }
}
