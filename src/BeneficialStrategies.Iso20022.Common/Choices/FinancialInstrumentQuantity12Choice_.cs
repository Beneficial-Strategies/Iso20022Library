// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be redeemed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.HoldingsRate))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.UnitsNumber),nameof(FinancialInstrumentQuantity12Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.OrderedAmount),nameof(FinancialInstrumentQuantity12Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.NetAmount),nameof(FinancialInstrumentQuantity12Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.GrossAmount),nameof(FinancialInstrumentQuantity12Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.HoldingsRate),nameof(FinancialInstrumentQuantity12Choice.HoldingsRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity12Choice.PercentageOfTotalSubscriptionAmount))]
    [IsoId("_RgvYAtp-Ed-ak6NoX_4Aeg_426549080")]
    [DisplayName("Financial Instrument Quantity 12 Choice")]
    public abstract partial record FinancialInstrumentQuantity12Choice_
    {
    }
}
