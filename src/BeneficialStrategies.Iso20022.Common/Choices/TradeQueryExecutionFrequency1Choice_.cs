// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the frequency of the trade query execution.
    /// </summary>
    [KnownType(typeof(TradeQueryExecutionFrequency1Choice.Daily))]
    [KnownType(typeof(TradeQueryExecutionFrequency1Choice.Weekly))]
    [KnownType(typeof(TradeQueryExecutionFrequency1Choice.Monthly))]
    [JsonDerivedType(
        typeof(TradeQueryExecutionFrequency1Choice.Daily),
        nameof(TradeQueryExecutionFrequency1Choice.Daily)
    )]
    [JsonDerivedType(
        typeof(TradeQueryExecutionFrequency1Choice.Weekly),
        nameof(TradeQueryExecutionFrequency1Choice.Weekly)
    )]
    [JsonDerivedType(
        typeof(TradeQueryExecutionFrequency1Choice.Monthly),
        nameof(TradeQueryExecutionFrequency1Choice.Monthly)
    )]
    [IsoId("_ZjhR4NGYEeaQk737TH1Fzw")]
    [DisplayName("Trade Query Execution Frequency 1 Choice")]
    public abstract record TradeQueryExecutionFrequency1Choice_ { }
}
