// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify whether the taxable income per share or per dividend is calculated.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat1Choice.Code))]
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TaxableIncomePerShareCalculatedFormat1Choice.Code),
        nameof(TaxableIncomePerShareCalculatedFormat1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TaxableIncomePerShareCalculatedFormat1Choice.Proprietary),
        nameof(TaxableIncomePerShareCalculatedFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3K2ldp-Ed-ak6NoX_4Aeg_-1453152737")]
    [DisplayName("Taxable Income Per Share Calculated Format 1 Choice")]
    public abstract record TaxableIncomePerShareCalculatedFormat1Choice_ { }
}
