// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Agricultural),
        nameof(AssetClassCommodity2Choice.Agricultural)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Energy),
        nameof(AssetClassCommodity2Choice.Energy)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Environmental),
        nameof(AssetClassCommodity2Choice.Environmental)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Freight),
        nameof(AssetClassCommodity2Choice.Freight)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Index),
        nameof(AssetClassCommodity2Choice.Index)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Metal),
        nameof(AssetClassCommodity2Choice.Metal)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Exotic),
        nameof(AssetClassCommodity2Choice.Exotic)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodity2Choice.Other),
        nameof(AssetClassCommodity2Choice.Other)
    )]
    [IsoId("_BzEmOCYyEeWHeosc_5RQEw")]
    [DisplayName("Asset Class Commodity 2 Choice")]
    public abstract record AssetClassCommodity2Choice_ { }
}
