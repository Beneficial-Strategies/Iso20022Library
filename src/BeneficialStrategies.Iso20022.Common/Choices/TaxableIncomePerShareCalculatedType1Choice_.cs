// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of a taxable income per share calcualted type.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculatedType1Choice.TaxableIncomePerShareCalculated))]
    [KnownType(typeof(TaxableIncomePerShareCalculatedType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculatedType1Choice.TaxableIncomePerShareCalculated),nameof(TaxableIncomePerShareCalculatedType1Choice.TaxableIncomePerShareCalculated))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculatedType1Choice.Proprietary),nameof(TaxableIncomePerShareCalculatedType1Choice.Proprietary))]
    [IsoId("_RfQKQtp-Ed-ak6NoX_4Aeg_1317820500")]
    [DisplayName("Taxable Income Per Share Calculated Type 1 Choice")]
    public abstract partial record TaxableIncomePerShareCalculatedType1Choice_
    {
    }
}
