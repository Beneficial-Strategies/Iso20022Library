// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify whether the taxable income per share or per dividend is calculated.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat4Choice.Code))]
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat4Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculatedFormat4Choice.Code),nameof(TaxableIncomePerShareCalculatedFormat4Choice.Code))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculatedFormat4Choice.Proprietary),nameof(TaxableIncomePerShareCalculatedFormat4Choice.Proprietary))]
    [IsoId("_c5WhE5KQEeWHWpTQn1FFVg")]
    [DisplayName("Taxable Income Per Share Calculated Format 4 Choice")]
    public abstract partial record TaxableIncomePerShareCalculatedFormat4Choice_
    {
    }
}
