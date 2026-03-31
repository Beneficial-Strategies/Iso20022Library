// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is polypropylene.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPolypropylene1Choice.Plastic))]
    [JsonDerivedType(
        typeof(AssetClassCommodityPolypropylene1Choice.Plastic),
        nameof(AssetClassCommodityPolypropylene1Choice.Plastic)
    )]
    [IsoId("_tIe6UGs5EeW9oI9ZdgWHPQ")]
    [DisplayName("Asset Class Commodity Polypropylene 1 Choice")]
    public abstract record AssetClassCommodityPolypropylene1Choice_ { }
}
