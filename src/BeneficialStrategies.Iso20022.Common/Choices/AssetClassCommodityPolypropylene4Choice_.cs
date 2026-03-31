// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is polypropylene.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityPolypropylene4Choice.Plastic))]
    [KnownType(typeof(AssetClassCommodityPolypropylene4Choice.Other))]
    [JsonDerivedType(
        typeof(AssetClassCommodityPolypropylene4Choice.Plastic),
        nameof(AssetClassCommodityPolypropylene4Choice.Plastic)
    )]
    [JsonDerivedType(
        typeof(AssetClassCommodityPolypropylene4Choice.Other),
        nameof(AssetClassCommodityPolypropylene4Choice.Other)
    )]
    [IsoId("_yRdvERZZEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity Polypropylene 4 Choice")]
    public abstract record AssetClassCommodityPolypropylene4Choice_ { }
}
