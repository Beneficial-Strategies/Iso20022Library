// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity18Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity18Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity18Choice.Unit),nameof(FinancialInstrumentQuantity18Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity18Choice.FaceAmount),nameof(FinancialInstrumentQuantity18Choice.FaceAmount))]
    [IsoId("_SrfnENorEeCWg-hsBVGrDA_1068412329")]
    [DisplayName("Financial Instrument Quantity 18 Choice")]
    public abstract partial record FinancialInstrumentQuantity18Choice_
    {
    }
}
