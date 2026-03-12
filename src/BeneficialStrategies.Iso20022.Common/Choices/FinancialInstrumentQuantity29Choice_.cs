// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units, amount of money or percentage.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.PercentageOfTotalSubscriptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.HoldingsRedemptionRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.UnitsNumber),nameof(FinancialInstrumentQuantity29Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity29Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.NetAmount),nameof(FinancialInstrumentQuantity29Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.GrossAmount),nameof(FinancialInstrumentQuantity29Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity29Choice.HoldingsRedemptionRate))]
    [IsoId("_5dOFoU_3Eea1ZIrmU5dI3w")]
    [DisplayName("Financial Instrument Quantity 29 Choice")]
    public abstract partial record FinancialInstrumentQuantity29Choice_
    {
    }
}
