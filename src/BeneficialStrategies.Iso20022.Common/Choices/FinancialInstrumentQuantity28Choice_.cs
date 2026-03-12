// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units, amount of money or percentage.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.HoldingsRedemptionRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.UnitsNumber),nameof(FinancialInstrumentQuantity28Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.GrossAmount),nameof(FinancialInstrumentQuantity28Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.NetAmount),nameof(FinancialInstrumentQuantity28Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity28Choice.HoldingsRedemptionRate))]
    [IsoId("_ZJ9SMThUEeaRwdGFv45qTQ")]
    [DisplayName("Financial Instrument Quantity 28 Choice")]
    public abstract partial record FinancialInstrumentQuantity28Choice_
    {
    }
}
