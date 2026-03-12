// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument61Choice.Security))]
    [KnownType(typeof(FinancialInstrument61Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument61Choice.OtherAsset))]
    [JsonDerivedType(typeof(FinancialInstrument61Choice.Security),nameof(FinancialInstrument61Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument61Choice.CashAsset),nameof(FinancialInstrument61Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument61Choice.OtherAsset),nameof(FinancialInstrument61Choice.OtherAsset))]
    [IsoId("_mDJucZNBEemQB_8XA98K0Q")]
    [DisplayName("Financial Instrument 61 Choice")]
    public abstract partial record FinancialInstrument61Choice_
    {
    }
}
