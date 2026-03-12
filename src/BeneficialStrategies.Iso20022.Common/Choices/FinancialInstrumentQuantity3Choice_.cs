// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be redeemed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.PercentageOfTotalSubscriptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.HoldingsRedemptionRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.UnitsNumber),nameof(FinancialInstrumentQuantity3Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity3Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.NetAmount),nameof(FinancialInstrumentQuantity3Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.GrossAmount),nameof(FinancialInstrumentQuantity3Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity3Choice.HoldingsRedemptionRate))]
    [IsoId("_VOten9p-Ed-ak6NoX_4Aeg_1922478092")]
    [DisplayName("Financial Instrument Quantity 3 Choice")]
    public abstract partial record FinancialInstrumentQuantity3Choice_
    {
    }
}
