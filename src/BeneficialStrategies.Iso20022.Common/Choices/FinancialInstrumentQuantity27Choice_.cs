// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of the number of units or amount of money.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity27Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity27Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity27Choice.NetAmount))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity27Choice.UnitsNumber),
        nameof(FinancialInstrumentQuantity27Choice.UnitsNumber)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity27Choice.GrossAmount),
        nameof(FinancialInstrumentQuantity27Choice.GrossAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity27Choice.NetAmount),
        nameof(FinancialInstrumentQuantity27Choice.NetAmount)
    )]
    [IsoId("_RoyRsDhSEeaRwdGFv45qTQ")]
    [DisplayName("Financial Instrument Quantity 27 Choice")]
    public abstract record FinancialInstrumentQuantity27Choice_ { }
}
