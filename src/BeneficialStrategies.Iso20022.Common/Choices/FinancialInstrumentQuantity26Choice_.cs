// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units, amount of money or percentage.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.PercentageOfTotalRedemptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.GrossAmount))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity26Choice.UnitsNumber),
        nameof(FinancialInstrumentQuantity26Choice.UnitsNumber)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity26Choice.PercentageOfTotalRedemptionAmount),
        nameof(FinancialInstrumentQuantity26Choice.PercentageOfTotalRedemptionAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity26Choice.NetAmount),
        nameof(FinancialInstrumentQuantity26Choice.NetAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity26Choice.GrossAmount),
        nameof(FinancialInstrumentQuantity26Choice.GrossAmount)
    )]
    [IsoId("_AYbkQU_4Eea1ZIrmU5dI3w")]
    [DisplayName("Financial Instrument Quantity 26 Choice")]
    public abstract record FinancialInstrumentQuantity26Choice_ { }
}
