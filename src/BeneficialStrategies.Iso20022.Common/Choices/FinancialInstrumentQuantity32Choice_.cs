// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the format for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity32Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity32Choice.NominalValue))]
    [KnownType(typeof(FinancialInstrumentQuantity32Choice.MonetaryValue))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity32Choice.Unit),
        nameof(FinancialInstrumentQuantity32Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity32Choice.NominalValue),
        nameof(FinancialInstrumentQuantity32Choice.NominalValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity32Choice.MonetaryValue),
        nameof(FinancialInstrumentQuantity32Choice.MonetaryValue)
    )]
    [IsoId("_Y6yLkZjgEeqkLZLH6DK3UQ")]
    [DisplayName("Financial Instrument Quantity 32 Choice")]
    public abstract record FinancialInstrumentQuantity32Choice_ { }
}
