// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of cash asset.
    /// </summary>
    [KnownType(typeof(CashAssetType1Choice.Code))]
    [KnownType(typeof(CashAssetType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CashAssetType1Choice.Code),nameof(CashAssetType1Choice.Code))]
    [JsonDerivedType(typeof(CashAssetType1Choice.Proprietary),nameof(CashAssetType1Choice.Proprietary))]
    [IsoId("_OWCEUEyIEeir2sRRVd9XhA")]
    [DisplayName("Cash Asset Type 1 Choice")]
    public abstract partial record CashAssetType1Choice_
    {
    }
}
