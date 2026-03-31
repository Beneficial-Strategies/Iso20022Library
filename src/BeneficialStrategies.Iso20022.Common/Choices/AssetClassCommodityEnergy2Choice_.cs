// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is energy.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Electricity))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.NaturalGas))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Oil))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Coal))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.InterEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.RenewableEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.LightEnd))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Distillates))]
    [KnownType(typeof(AssetClassCommodityEnergy2Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.Electricity),
        nameof(AssetClassCommodityEnergy2Choice.Electricity)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.NaturalGas),
        nameof(AssetClassCommodityEnergy2Choice.NaturalGas)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.Oil),
        nameof(AssetClassCommodityEnergy2Choice.Oil)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.Coal),
        nameof(AssetClassCommodityEnergy2Choice.Coal)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.InterEnergy),
        nameof(AssetClassCommodityEnergy2Choice.InterEnergy)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.RenewableEnergy),
        nameof(AssetClassCommodityEnergy2Choice.RenewableEnergy)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.LightEnd),
        nameof(AssetClassCommodityEnergy2Choice.LightEnd)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.Distillates),
        nameof(AssetClassCommodityEnergy2Choice.Distillates)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityEnergy2Choice.Other),
        nameof(AssetClassCommodityEnergy2Choice.Other)
    )]
    [IsoId("_xupNAbvsEeiLRYqS-r-R-A")]
    [DisplayName("Asset Class Commodity Energy 2 Choice")]
    public abstract record AssetClassCommodityEnergy2Choice_ { }
}
