// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify whether the taxable income per share or per dividend is calculated.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Code))]
    [KnownType(typeof(TaxableIncomePerShareCalculatedFormat3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TaxableIncomePerShareCalculatedFormat3Choice.Code),
        nameof(TaxableIncomePerShareCalculatedFormat3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TaxableIncomePerShareCalculatedFormat3Choice.Proprietary),
        nameof(TaxableIncomePerShareCalculatedFormat3Choice.Proprietary)
    )]
    [IsoId("_RaMwQUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Taxable Income Per Share Calculated Format 3 Choice")]
    public abstract record TaxableIncomePerShareCalculatedFormat3Choice_ { }
}
