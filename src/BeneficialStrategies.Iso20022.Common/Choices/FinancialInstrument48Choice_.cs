// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to specific an instrument of type ISIN, LEI or Index.
    /// </summary>
    [KnownType(typeof(FinancialInstrument48Choice.ISIN))]
    [KnownType(typeof(FinancialInstrument48Choice.LEI))]
    [KnownType(typeof(FinancialInstrument48Choice.Index))]
    [JsonDerivedType(
        typeof(FinancialInstrument48Choice.ISIN),
        nameof(FinancialInstrument48Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrument48Choice.LEI),
        nameof(FinancialInstrument48Choice.LEI)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrument48Choice.Index),
        nameof(FinancialInstrument48Choice.Index)
    )]
    [IsoId("_HQWTxX5aEea2k7EBUopqxw")]
    [DisplayName("Financial Instrument 48 Choice")]
    public abstract record FinancialInstrument48Choice_ { }
}
