// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a quantity expressed in units, face amount or amortised amount and a quantity expressed as an amount.
    /// </summary>
    [KnownType(typeof(QuantityOrAmount1Choice.Quantity))]
    [KnownType(typeof(QuantityOrAmount1Choice.Amount))]
    [JsonDerivedType(typeof(QuantityOrAmount1Choice.Quantity),nameof(QuantityOrAmount1Choice.Quantity))]
    [JsonDerivedType(typeof(QuantityOrAmount1Choice.Amount),nameof(QuantityOrAmount1Choice.Amount))]
    [IsoId("_Q-K2cNp-Ed-ak6NoX_4Aeg_1028055556")]
    [DisplayName("Quantity Or Amount 1 Choice")]
    public abstract partial record QuantityOrAmount1Choice_
    {
    }
}
