// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade transaction condition.
    /// </summary>
    [KnownType(typeof(TradeTransactionCondition6Choice.Code))]
    [KnownType(typeof(TradeTransactionCondition6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TradeTransactionCondition6Choice.Code),
        nameof(TradeTransactionCondition6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TradeTransactionCondition6Choice.Proprietary),
        nameof(TradeTransactionCondition6Choice.Proprietary)
    )]
    [IsoId("_5msltZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Transaction Condition 6 Choice")]
    public abstract record TradeTransactionCondition6Choice_ { }
}
