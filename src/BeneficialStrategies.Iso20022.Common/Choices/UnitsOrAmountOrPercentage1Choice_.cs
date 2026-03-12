// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or number of units or percentage.
    /// </summary>
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Amount))]
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Unit))]
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Percentage))]
    [JsonDerivedType(typeof(UnitsOrAmountOrPercentage1Choice.Amount),nameof(UnitsOrAmountOrPercentage1Choice.Amount))]
    [JsonDerivedType(typeof(UnitsOrAmountOrPercentage1Choice.Unit),nameof(UnitsOrAmountOrPercentage1Choice.Unit))]
    [JsonDerivedType(typeof(UnitsOrAmountOrPercentage1Choice.Percentage),nameof(UnitsOrAmountOrPercentage1Choice.Percentage))]
    [IsoId("_-TmAQQjcEeS5F6qHcKOrew")]
    [DisplayName("Units Or Amount Or Percentage 1 Choice")]
    public abstract partial record UnitsOrAmountOrPercentage1Choice_
    {
    }
}
