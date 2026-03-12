// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for taxable income per share calculated.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculated2Choice.Code))]
    [KnownType(typeof(TaxableIncomePerShareCalculated2Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculated2Choice.Code),nameof(TaxableIncomePerShareCalculated2Choice.Code))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculated2Choice.Proprietary),nameof(TaxableIncomePerShareCalculated2Choice.Proprietary))]
    [IsoId("_wM39wThgEeamLZQeccJa7w")]
    [DisplayName("Taxable Income Per Share Calculated 2 Choice")]
    public abstract partial record TaxableIncomePerShareCalculated2Choice_
    {
    }
}
