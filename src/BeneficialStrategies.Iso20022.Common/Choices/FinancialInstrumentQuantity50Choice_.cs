// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units, amount of money or percentage.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity50Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity50Choice.PercentageOfTotalSubscriptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity50Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity50Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity50Choice.DigitalTokenUnit))]
    [KnownType(typeof(FinancialInstrumentQuantity50Choice.HoldingsRedemptionRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity50Choice.UnitsNumber), nameof(FinancialInstrumentQuantity50Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity50Choice.PercentageOfTotalSubscriptionAmount), nameof(FinancialInstrumentQuantity50Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity50Choice.NetAmount), nameof(FinancialInstrumentQuantity50Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity50Choice.GrossAmount), nameof(FinancialInstrumentQuantity50Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity50Choice.DigitalTokenUnit), nameof(FinancialInstrumentQuantity50Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity50Choice.HoldingsRedemptionRate), nameof(FinancialInstrumentQuantity50Choice.HoldingsRedemptionRate))]
    [IsoId("549c8b15-061f-49c8-8379-67a9ed4b01a5")]
    [DisplayName("Financial Instrument Quantity 50 Choice")]
    public abstract record FinancialInstrumentQuantity50Choice_ { }
}
