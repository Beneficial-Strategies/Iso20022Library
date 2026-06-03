// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units or amount of money.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity49Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity49Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity49Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity49Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity49Choice.UnitsNumber), nameof(FinancialInstrumentQuantity49Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity49Choice.GrossAmount), nameof(FinancialInstrumentQuantity49Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity49Choice.NetAmount), nameof(FinancialInstrumentQuantity49Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity49Choice.DigitalTokenUnit), nameof(FinancialInstrumentQuantity49Choice.DigitalTokenUnit))]
    [IsoId("c5556994-830b-4d35-8355-f621b5085941")]
    [DisplayName("Financial Instrument Quantity 49 Choice")]
    public abstract record FinancialInstrumentQuantity49Choice_ { }
}
