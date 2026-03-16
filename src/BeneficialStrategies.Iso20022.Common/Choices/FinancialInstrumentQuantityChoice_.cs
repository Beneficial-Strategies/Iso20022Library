// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantityChoice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantityChoice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantityChoice.AmortisedValue))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantityChoice.Unit),
        nameof(FinancialInstrumentQuantityChoice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantityChoice.FaceAmount),
        nameof(FinancialInstrumentQuantityChoice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantityChoice.AmortisedValue),
        nameof(FinancialInstrumentQuantityChoice.AmortisedValue)
    )]
    [IsoId("_Sn-F2Np-Ed-ak6NoX_4Aeg_1265174989")]
    [DisplayName("Financial Instrument Quantity Choice")]
    public abstract record FinancialInstrumentQuantityChoice_ { }
}
