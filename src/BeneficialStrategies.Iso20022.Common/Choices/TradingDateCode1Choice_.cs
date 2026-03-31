// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading date code.
    /// </summary>
    [KnownType(typeof(TradingDateCode1Choice.Code))]
    [KnownType(typeof(TradingDateCode1Choice.Proprietary))]
    [JsonDerivedType(typeof(TradingDateCode1Choice.Code), nameof(TradingDateCode1Choice.Code))]
    [JsonDerivedType(
        typeof(TradingDateCode1Choice.Proprietary),
        nameof(TradingDateCode1Choice.Proprietary)
    )]
    [IsoId("_AXUwUdokEeC60axPepSq7g_2130878160")]
    [DisplayName("Trading Date Code 1 Choice")]
    public abstract record TradingDateCode1Choice_ { }
}
