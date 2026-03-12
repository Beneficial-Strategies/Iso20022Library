// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of calculation basis type.
    /// </summary>
    [KnownType(typeof(TaxCalculationBasisType1Choice.Basis))]
    [KnownType(typeof(TaxCalculationBasisType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxCalculationBasisType1Choice.Basis),nameof(TaxCalculationBasisType1Choice.Basis))]
    [JsonDerivedType(typeof(TaxCalculationBasisType1Choice.Proprietary),nameof(TaxCalculationBasisType1Choice.Proprietary))]
    [IsoId("_RfQKRdp-Ed-ak6NoX_4Aeg_-1842013319")]
    [DisplayName("Tax Calculation Basis Type 1 Choice")]
    public abstract partial record TaxCalculationBasisType1Choice_
    {
    }
}
