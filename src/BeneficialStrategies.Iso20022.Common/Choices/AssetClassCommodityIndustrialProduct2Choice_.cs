// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is industrial product.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityIndustrialProduct2Choice.Construction))]
    [KnownType(typeof(AssetClassCommodityIndustrialProduct2Choice.Manufacturing))]
    [JsonDerivedType(typeof(AssetClassCommodityIndustrialProduct2Choice.Construction),nameof(AssetClassCommodityIndustrialProduct2Choice.Construction))]
    [JsonDerivedType(typeof(AssetClassCommodityIndustrialProduct2Choice.Manufacturing),nameof(AssetClassCommodityIndustrialProduct2Choice.Manufacturing))]
    [IsoId("_OS8SQRZZEe2QNcZTDeoKnQ")]
    [DisplayName("Asset Class Commodity Industrial Product 2 Choice")]
    public abstract partial record AssetClassCommodityIndustrialProduct2Choice_
    {
    }
}
