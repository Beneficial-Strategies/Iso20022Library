// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount and a coefficient.
    /// </summary>
    [KnownType(typeof(AmountOrCoefficientPrice1Choice.Amount))]
    [KnownType(typeof(AmountOrCoefficientPrice1Choice.Coefficient))]
    [JsonDerivedType(typeof(AmountOrCoefficientPrice1Choice.Amount),nameof(AmountOrCoefficientPrice1Choice.Amount))]
    [JsonDerivedType(typeof(AmountOrCoefficientPrice1Choice.Coefficient),nameof(AmountOrCoefficientPrice1Choice.Coefficient))]
    [IsoId("_jBTw9O5NEeCisYr99QEiWA_-2039620670")]
    [DisplayName("Amount Or Coefficient Price 1 Choice")]
    public abstract partial record AmountOrCoefficientPrice1Choice_
    {
    }
}
