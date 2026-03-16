// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Financial Instrument99Choice.
    /// </summary>
    [KnownType(typeof(FinancialInstrument99Choice.Identification))]
    [KnownType(typeof(FinancialInstrument99Choice.StrategyInstruments))]
    [JsonDerivedType(typeof(FinancialInstrument99Choice.Identification),nameof(FinancialInstrument99Choice.Identification))]
    [JsonDerivedType(typeof(FinancialInstrument99Choice.StrategyInstruments),nameof(FinancialInstrument99Choice.StrategyInstruments))]
    [IsoId("_1GEyICuiEe6NvawojqaGhg")]
    [DisplayName("Financial Instrument99Choice")]
    public abstract partial record FinancialInstrument99Choice_
    {
    }
}
