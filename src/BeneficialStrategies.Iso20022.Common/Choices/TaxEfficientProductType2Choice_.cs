// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of tax efficient product.
    /// </summary>
    [KnownType(typeof(TaxEfficientProductType2Choice.Code))]
    [KnownType(typeof(TaxEfficientProductType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TaxEfficientProductType2Choice.Code),
        nameof(TaxEfficientProductType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TaxEfficientProductType2Choice.Proprietary),
        nameof(TaxEfficientProductType2Choice.Proprietary)
    )]
    [IsoId("_Ugn1YZNNEemQB_8XA98K0Q")]
    [DisplayName("Tax Efficient Product Type 2 Choice")]
    public abstract record TaxEfficientProductType2Choice_ { }
}
