// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of commodity.
    /// </summary>
    [KnownType(typeof(AssetClassDetailedSubProductType1Choice.Code))]
    [KnownType(typeof(AssetClassDetailedSubProductType1Choice.Proprietary))]
    [JsonDerivedType(typeof(AssetClassDetailedSubProductType1Choice.Code),nameof(AssetClassDetailedSubProductType1Choice.Code))]
    [JsonDerivedType(typeof(AssetClassDetailedSubProductType1Choice.Proprietary),nameof(AssetClassDetailedSubProductType1Choice.Proprietary))]
    [IsoId("_KDl0cI16Eeet3cKIYK84nw")]
    [DisplayName("Asset Class Detailed Sub Product Type 1 Choice")]
    public abstract partial record AssetClassDetailedSubProductType1Choice_
    {
    }
}
