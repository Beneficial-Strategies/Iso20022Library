// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is energy.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.Electricity))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.NaturalGas))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.Oil))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.Coal))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.InterEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.RenewableEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.LightEnd))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.Distillates))]
    [KnownType(typeof(AssetClassCommodityEnergy3Choice.Other))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.Electricity),nameof(AssetClassCommodityEnergy3Choice.Electricity))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.NaturalGas),nameof(AssetClassCommodityEnergy3Choice.NaturalGas))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.Oil),nameof(AssetClassCommodityEnergy3Choice.Oil))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.Coal),nameof(AssetClassCommodityEnergy3Choice.Coal))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.InterEnergy),nameof(AssetClassCommodityEnergy3Choice.InterEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.RenewableEnergy),nameof(AssetClassCommodityEnergy3Choice.RenewableEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.LightEnd),nameof(AssetClassCommodityEnergy3Choice.LightEnd))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.Distillates),nameof(AssetClassCommodityEnergy3Choice.Distillates))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy3Choice.Other),nameof(AssetClassCommodityEnergy3Choice.Other))]
    [IsoId("_O6FdcU8SEe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Energy 3 Choice")]
    public abstract partial record AssetClassCommodityEnergy3Choice_
    {
    }
}
