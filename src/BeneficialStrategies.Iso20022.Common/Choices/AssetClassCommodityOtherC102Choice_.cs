// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines commodity attributes of a derivative where the type is other C10.
    /// </summary>
    [KnownType(typeof(AssetClassCommodityOtherC102Choice.Deliverable))]
    [KnownType(typeof(AssetClassCommodityOtherC102Choice.NonDeliverable))]
    [JsonDerivedType(typeof(AssetClassCommodityOtherC102Choice.Deliverable),nameof(AssetClassCommodityOtherC102Choice.Deliverable))]
    [JsonDerivedType(typeof(AssetClassCommodityOtherC102Choice.NonDeliverable),nameof(AssetClassCommodityOtherC102Choice.NonDeliverable))]
    [IsoId("_lTiEcXvyEeanCNPcMT7sSg")]
    [DisplayName("Asset Class Commodity Other C 102 Choice")]
    public abstract partial record AssetClassCommodityOtherC102Choice_
    {
    }
}
