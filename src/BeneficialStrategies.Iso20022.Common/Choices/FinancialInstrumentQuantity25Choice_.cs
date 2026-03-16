// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the format for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity25Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity25Choice.NominalValue))]
    [KnownType(typeof(FinancialInstrumentQuantity25Choice.MonetaryValue))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity25Choice.Unit),
        nameof(FinancialInstrumentQuantity25Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity25Choice.NominalValue),
        nameof(FinancialInstrumentQuantity25Choice.NominalValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity25Choice.MonetaryValue),
        nameof(FinancialInstrumentQuantity25Choice.MonetaryValue)
    )]
    [IsoId("_AOzcUYIiEeW_KPkCyw2GUA")]
    [DisplayName("Financial Instrument Quantity 25 Choice")]
    public abstract record FinancialInstrumentQuantity25Choice_ { }
}
