// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be subscribed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity4Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity4Choice.PercentageOfTotalRedemptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity4Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity4Choice.GrossAmount))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity4Choice.UnitsNumber),
        nameof(FinancialInstrumentQuantity4Choice.UnitsNumber)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity4Choice.PercentageOfTotalRedemptionAmount),
        nameof(FinancialInstrumentQuantity4Choice.PercentageOfTotalRedemptionAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity4Choice.NetAmount),
        nameof(FinancialInstrumentQuantity4Choice.NetAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity4Choice.GrossAmount),
        nameof(FinancialInstrumentQuantity4Choice.GrossAmount)
    )]
    [IsoId("_VO3PlNp-Ed-ak6NoX_4Aeg_-1046400121")]
    [DisplayName("Financial Instrument Quantity 4 Choice")]
    public abstract record FinancialInstrumentQuantity4Choice_ { }
}
