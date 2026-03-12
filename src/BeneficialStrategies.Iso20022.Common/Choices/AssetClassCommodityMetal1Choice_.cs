// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is metal.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityMetal1Choice.NonPrecious))]
    [KnownType(typeof(AssetClassCommodityMetal1Choice.Precious))]
    [JsonDerivedType(typeof(AssetClassCommodityMetal1Choice.NonPrecious),nameof(AssetClassCommodityMetal1Choice.NonPrecious))]
    [JsonDerivedType(typeof(AssetClassCommodityMetal1Choice.Precious),nameof(AssetClassCommodityMetal1Choice.Precious))]
    [IsoId("_D1rdUw2rEeW72qLtWESimw")]
    [DisplayName("Asset Class Commodity Metal 1 Choice")]
    public abstract partial record AssetClassCommodityMetal1Choice_
    {
    }
}
