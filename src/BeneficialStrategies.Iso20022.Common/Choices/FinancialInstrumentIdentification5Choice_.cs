// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for identifying the underlying instruments that a derivative can consist of.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentIdentification5Choice.Single))]
    [KnownType(typeof(FinancialInstrumentIdentification5Choice.Basket))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification5Choice.Single),nameof(FinancialInstrumentIdentification5Choice.Single))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification5Choice.Basket),nameof(FinancialInstrumentIdentification5Choice.Basket))]
    [IsoId("_HH3GN35aEea2k7EBUopqxw")]
    [DisplayName("Financial Instrument Identification 5 Choice")]
    public abstract partial record FinancialInstrumentIdentification5Choice_
    {
    }
}
