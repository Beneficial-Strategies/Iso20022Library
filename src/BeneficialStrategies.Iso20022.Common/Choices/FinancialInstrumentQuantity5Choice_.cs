// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be redeemed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.UnitsNumber),nameof(FinancialInstrumentQuantity5Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.NetAmount),nameof(FinancialInstrumentQuantity5Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.GrossAmount),nameof(FinancialInstrumentQuantity5Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate))]
    [IsoId("_Soaxwdp-Ed-ak6NoX_4Aeg_1036643949")]
    [DisplayName("Financial Instrument Quantity 5 Choice")]
    public abstract partial record FinancialInstrumentQuantity5Choice_
    {
    }
}
