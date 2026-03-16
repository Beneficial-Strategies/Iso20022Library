// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of holding indicator and aggregated position of holdings.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentAggregateBalance1Choice.HoldingsIndicator))]
    [KnownType(typeof(FinancialInstrumentAggregateBalance1Choice.HoldingBalance))]
    [JsonDerivedType(
        typeof(FinancialInstrumentAggregateBalance1Choice.HoldingsIndicator),
        nameof(FinancialInstrumentAggregateBalance1Choice.HoldingsIndicator)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentAggregateBalance1Choice.HoldingBalance),
        nameof(FinancialInstrumentAggregateBalance1Choice.HoldingBalance)
    )]
    [IsoId("_PW7ItqCCEeOEyO7fCl8lLA")]
    [DisplayName("Financial Instrument Aggregate Balance 1 Choice")]
    public abstract record FinancialInstrumentAggregateBalance1Choice_ { }
}
