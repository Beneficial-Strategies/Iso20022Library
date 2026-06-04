// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculated3Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code and proprietary format for taxable income per share calculated.</summary>
    [IsoId("2f01d364-57cd-42cd-a23a-b2d99d8eb3ce")]
    [DisplayName("Taxable Income Per Share Calculated 3 Choice")]
    [KnownType(typeof(TaxableIncomePerShareCalculated3Choice.Code))]
    [KnownType(typeof(TaxableIncomePerShareCalculated3Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculated3Choice.Code))]
    [JsonDerivedType(typeof(TaxableIncomePerShareCalculated3Choice.Proprietary))]
    public abstract record TaxableIncomePerShareCalculated3Choice_
    {
    }
}
