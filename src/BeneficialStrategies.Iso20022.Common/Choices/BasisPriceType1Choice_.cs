// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the basis price type.
    /// </summary>
    [KnownType(typeof(BasisPriceType1Choice.Code))]
    [KnownType(typeof(BasisPriceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(BasisPriceType1Choice.Code),nameof(BasisPriceType1Choice.Code))]
    [JsonDerivedType(typeof(BasisPriceType1Choice.Proprietary),nameof(BasisPriceType1Choice.Proprietary))]
    [IsoId("_RBTC9Np-Ed-ak6NoX_4Aeg_1169196122")]
    [DisplayName("Basis Price Type 1 Choice")]
    public abstract partial record BasisPriceType1Choice_
    {
    }
}
