// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.TradingSystemReport1Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of a trading system report either as a new report or as a cancellation report.</summary>
    [IsoId("_9MVFoGFcEfC-1NkZ9TkdKA")]
    [DisplayName("Trading System Report 1 Choice")]
    [KnownType(typeof(TradingSystemReport1Choice.New))]
    [KnownType(typeof(TradingSystemReport1Choice.Cancellation))]
    [JsonDerivedType(typeof(TradingSystemReport1Choice.New))]
    [JsonDerivedType(typeof(TradingSystemReport1Choice.Cancellation))]
    public abstract record TradingSystemReport1Choice_
    {
    }
}
