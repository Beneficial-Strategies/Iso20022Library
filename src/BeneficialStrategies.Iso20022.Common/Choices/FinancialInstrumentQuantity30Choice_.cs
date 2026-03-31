// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the format for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity30Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity30Choice.NominalValue))]
    [KnownType(typeof(FinancialInstrumentQuantity30Choice.MonetaryValue))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity30Choice.Unit),
        nameof(FinancialInstrumentQuantity30Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity30Choice.NominalValue),
        nameof(FinancialInstrumentQuantity30Choice.NominalValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity30Choice.MonetaryValue),
        nameof(FinancialInstrumentQuantity30Choice.MonetaryValue)
    )]
    [IsoId("_zI00Mf9jEea3W_f2lS_aiw")]
    [DisplayName("Financial Instrument Quantity 30 Choice")]
    public abstract record FinancialInstrumentQuantity30Choice_ { }
}
