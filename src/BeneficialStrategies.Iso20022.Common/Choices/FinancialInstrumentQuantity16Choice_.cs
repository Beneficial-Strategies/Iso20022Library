// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.Unit),nameof(FinancialInstrumentQuantity16Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.FaceAmount),nameof(FinancialInstrumentQuantity16Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.AmortisedValue),nameof(FinancialInstrumentQuantity16Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.Code),nameof(FinancialInstrumentQuantity16Choice.Code))]
    [IsoId("_CfV6b-GaEd-1Ktb5rVaajw")]
    [DisplayName("Financial Instrument Quantity 16 Choice")]
    public abstract partial record FinancialInstrumentQuantity16Choice_
    {
    }
}
