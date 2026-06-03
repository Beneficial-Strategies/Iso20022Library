// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units, amount of money or percentage.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity48Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity48Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity48Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity48Choice.DigitalTokenUnit))]
    [KnownType(typeof(FinancialInstrumentQuantity48Choice.HoldingsRedemptionRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity48Choice.UnitsNumber), nameof(FinancialInstrumentQuantity48Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity48Choice.GrossAmount), nameof(FinancialInstrumentQuantity48Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity48Choice.NetAmount), nameof(FinancialInstrumentQuantity48Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity48Choice.DigitalTokenUnit), nameof(FinancialInstrumentQuantity48Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity48Choice.HoldingsRedemptionRate), nameof(FinancialInstrumentQuantity48Choice.HoldingsRedemptionRate))]
    [IsoId("c3608a25-7ef0-409d-8054-afb7fc1acf21")]
    [DisplayName("Financial Instrument Quantity 48 Choice")]
    public abstract record FinancialInstrumentQuantity48Choice_ { }
}
