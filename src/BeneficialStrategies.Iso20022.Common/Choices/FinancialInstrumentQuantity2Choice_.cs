// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity2Choice.Code))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity2Choice.Unit),
        nameof(FinancialInstrumentQuantity2Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity2Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity2Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity2Choice.AmortisedValue),
        nameof(FinancialInstrumentQuantity2Choice.AmortisedValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity2Choice.Code),
        nameof(FinancialInstrumentQuantity2Choice.Code)
    )]
    [IsoId("_Sn-F09p-Ed-ak6NoX_4Aeg_-85763525")]
    [DisplayName("Financial Instrument Quantity 2 Choice")]
    public abstract record FinancialInstrumentQuantity2Choice_ { }
}
