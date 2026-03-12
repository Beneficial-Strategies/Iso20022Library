// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount and percentage.
    /// </summary>
    [KnownType(typeof(AmountOrPercentage1Choice.DefinedAmount))]
    [KnownType(typeof(AmountOrPercentage1Choice.PercentageAmount))]
    [JsonDerivedType(typeof(AmountOrPercentage1Choice.DefinedAmount),nameof(AmountOrPercentage1Choice.DefinedAmount))]
    [JsonDerivedType(typeof(AmountOrPercentage1Choice.PercentageAmount),nameof(AmountOrPercentage1Choice.PercentageAmount))]
    [IsoId("_986x5nltEeG7BsjMvd1mEw_930379145")]
    [DisplayName("Amount Or Percentage 1 Choice")]
    public abstract partial record AmountOrPercentage1Choice_
    {
    }
}
