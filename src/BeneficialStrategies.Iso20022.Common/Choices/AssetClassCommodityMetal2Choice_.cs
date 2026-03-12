// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is metal.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityMetal2Choice.NonPrecious))]
    [KnownType(typeof(AssetClassCommodityMetal2Choice.Precious))]
    [JsonDerivedType(typeof(AssetClassCommodityMetal2Choice.NonPrecious),nameof(AssetClassCommodityMetal2Choice.NonPrecious))]
    [JsonDerivedType(typeof(AssetClassCommodityMetal2Choice.Precious),nameof(AssetClassCommodityMetal2Choice.Precious))]
    [IsoId("_DnKNIU8REe2PGo0mhYCh1g")]
    [DisplayName("Asset Class Commodity Metal 2 Choice")]
    public abstract partial record AssetClassCommodityMetal2Choice_
    {
    }
}
