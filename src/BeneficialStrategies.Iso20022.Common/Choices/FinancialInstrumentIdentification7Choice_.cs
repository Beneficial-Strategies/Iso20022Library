// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for identifying the underlying instruments that a derivative can consist of.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentIdentification7Choice.Single))]
    [KnownType(typeof(FinancialInstrumentIdentification7Choice.Basket))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification7Choice.Single),nameof(FinancialInstrumentIdentification7Choice.Single))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification7Choice.Basket),nameof(FinancialInstrumentIdentification7Choice.Basket))]
    [IsoId("_K9o5cYG-EeaalK9UbuVGFw")]
    [DisplayName("Financial Instrument Identification 7 Choice")]
    public abstract partial record FinancialInstrumentIdentification7Choice_
    {
    }
}
