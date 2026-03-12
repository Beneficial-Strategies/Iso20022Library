// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of tax efficient product.
    /// </summary>
    [KnownType(typeof(TaxEfficientProductType1Choice.Code))]
    [KnownType(typeof(TaxEfficientProductType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxEfficientProductType1Choice.Code),nameof(TaxEfficientProductType1Choice.Code))]
    [JsonDerivedType(typeof(TaxEfficientProductType1Choice.Proprietary),nameof(TaxEfficientProductType1Choice.Proprietary))]
    [IsoId("_FKf7AE4LEeiQHa-q1Uephw")]
    [DisplayName("Tax Efficient Product Type 1 Choice")]
    public abstract partial record TaxEfficientProductType1Choice_
    {
    }
}
