// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantitySearch2Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantitySearch2Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantitySearch2Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantitySearch2Choice.Unit), nameof(FinancialInstrumentQuantitySearch2Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantitySearch2Choice.FaceAmount), nameof(FinancialInstrumentQuantitySearch2Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantitySearch2Choice.AmortisedValue), nameof(FinancialInstrumentQuantitySearch2Choice.AmortisedValue))]
    [IsoId("_eayJoWqWEemz04WrKJaMEA")]
    [DisplayName("Financial Instrument Quantity Search 2 Choice")]
    public abstract record FinancialInstrumentQuantitySearch2Choice_ { }
}
