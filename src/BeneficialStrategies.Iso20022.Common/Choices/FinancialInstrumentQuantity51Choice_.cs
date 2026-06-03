// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units, amount of money or percentage.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity51Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity51Choice.PercentageOfTotalRedemptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity51Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity51Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity51Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity51Choice.UnitsNumber), nameof(FinancialInstrumentQuantity51Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity51Choice.PercentageOfTotalRedemptionAmount), nameof(FinancialInstrumentQuantity51Choice.PercentageOfTotalRedemptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity51Choice.NetAmount), nameof(FinancialInstrumentQuantity51Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity51Choice.GrossAmount), nameof(FinancialInstrumentQuantity51Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity51Choice.DigitalTokenUnit), nameof(FinancialInstrumentQuantity51Choice.DigitalTokenUnit))]
    [IsoId("b40404fc-ad76-4bd5-b351-bc31cce8c5a3")]
    [DisplayName("Financial Instrument Quantity 51 Choice")]
    public abstract record FinancialInstrumentQuantity51Choice_ { }
}
