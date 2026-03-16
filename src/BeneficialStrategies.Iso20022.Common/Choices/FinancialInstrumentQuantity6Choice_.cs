// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be subscribed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.PercentageOfTotalRedemptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.GrossAmount))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity6Choice.UnitsNumber),
        nameof(FinancialInstrumentQuantity6Choice.UnitsNumber)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity6Choice.PercentageOfTotalRedemptionAmount),
        nameof(FinancialInstrumentQuantity6Choice.PercentageOfTotalRedemptionAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity6Choice.NetAmount),
        nameof(FinancialInstrumentQuantity6Choice.NetAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity6Choice.GrossAmount),
        nameof(FinancialInstrumentQuantity6Choice.GrossAmount)
    )]
    [IsoId("_SoRAxNp-Ed-ak6NoX_4Aeg_-1931223701")]
    [DisplayName("Financial Instrument Quantity 6 Choice")]
    public abstract record FinancialInstrumentQuantity6Choice_ { }
}
