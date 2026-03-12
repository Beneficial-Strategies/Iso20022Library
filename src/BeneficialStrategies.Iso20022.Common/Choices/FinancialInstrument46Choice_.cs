// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies underlying instruments or index a derivative has.
    /// </summary>
    [KnownType(typeof(FinancialInstrument46Choice.ISIN))]
    [KnownType(typeof(FinancialInstrument46Choice.Index))]
    [JsonDerivedType(typeof(FinancialInstrument46Choice.ISIN),nameof(FinancialInstrument46Choice.ISIN))]
    [JsonDerivedType(typeof(FinancialInstrument46Choice.Index),nameof(FinancialInstrument46Choice.Index))]
    [IsoId("_X1AUQ738EeWvRsMSLyTf-A")]
    [DisplayName("Financial Instrument 46 Choice")]
    public abstract partial record FinancialInstrument46Choice_
    {
    }
}
