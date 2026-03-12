// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is energy.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Electricity))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.NaturalGas))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Oil))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Coal))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.InterEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.RenewableEnergy))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.LightEnd))]
    [KnownType(typeof(AssetClassCommodityEnergy1Choice.Distillates))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Electricity),nameof(AssetClassCommodityEnergy1Choice.Electricity))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.NaturalGas),nameof(AssetClassCommodityEnergy1Choice.NaturalGas))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Oil),nameof(AssetClassCommodityEnergy1Choice.Oil))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Coal),nameof(AssetClassCommodityEnergy1Choice.Coal))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.InterEnergy),nameof(AssetClassCommodityEnergy1Choice.InterEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.RenewableEnergy),nameof(AssetClassCommodityEnergy1Choice.RenewableEnergy))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.LightEnd),nameof(AssetClassCommodityEnergy1Choice.LightEnd))]
    [JsonDerivedType(typeof(AssetClassCommodityEnergy1Choice.Distillates),nameof(AssetClassCommodityEnergy1Choice.Distillates))]
    [IsoId("_pBoTZg2nEeW72qLtWESimw")]
    [DisplayName("Asset Class Commodity Energy 1 Choice")]
    public abstract partial record AssetClassCommodityEnergy1Choice_
    {
    }
}
